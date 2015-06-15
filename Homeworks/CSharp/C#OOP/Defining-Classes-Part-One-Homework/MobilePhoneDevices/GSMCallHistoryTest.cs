namespace MobilePhoneDevices
{
    using System;
    using System.Text;

    public class GSMCallHistoryTest
    {
        public static GSM myGSM = new GSM("Experia", "Sony-Ericson");

        public static GSM GenerateCallHistory()
        {
             GSM myGsm = new GSM("Experia", "Sony-Ericson");
            myGSM.AddingCall(new Call(new DateTime(2015, 03, 09, 22, 03, 05), "+359 879 654321", 30));
            myGSM.AddingCall(new Call(new DateTime(2015, 03, 10, 15, 13, 17), "+359 899 123456", 112));
            myGSM.AddingCall(new Call(new DateTime(2015, 03, 10, 18, 03, 43), "+359 879 654321", 49));
            myGSM.AddingCall(new Call(new DateTime(2015, 03, 15, 11, 35, 25), "+359 856 754236", 154));
            myGSM.AddingCall(new Call(new DateTime(2015, 03, 16, 17, 03, 14), "+359 897 651241", 237));

            return myGSM;
        }
    }
}
