namespace MobilePhoneDevices
{
    using System;
    using System.Collections.Generic;
    
    class RunApplication
    {
        public const decimal pricePerMinute = 0.37m;
        public static GSM myPhone = GSMCallHistoryTest.GenerateCallHistory();
        static void Main()
        {
            List<GSM> phones = GSMTest.GeneratePhones();
            foreach (var GSM in phones)
            {
                Console.WriteLine(GSM.ToString());
            }
            Console.WriteLine("\nCall History Test \n");
            PrintCallHistory(myPhone);
            Console.WriteLine("Removed longest call");
            Call longestCall = myPhone.CallHistory[0];
            foreach (var call in myPhone.CallHistory)
            {
                if (call.Duration > longestCall.Duration)
                {
                    longestCall = call;
                }
            }
            myPhone.DelitingCall(longestCall);
            PrintCallHistory(myPhone);
            Console.WriteLine("The call history is clear.");
            myPhone.ClearCallHistory();
            PrintCallHistory(myPhone);
        }
        static void PrintCallHistory(GSM gsm)
        {

            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine(call.ToString());
            }
            Console.WriteLine("\nTotal prise of calls: {0:c}\n", myPhone.TotalPriceOfTheCalls(pricePerMinute));
        }
    }
}
