using System;

class AppearanceCount
{
    //•	Write a method that counts how many times given number appears in given array.
    //•	Write a test program to check if the method is workings correctly.
    
    
    static int RepeatedNumber (double[]arr,double number)
    {
        int counter = 0;

        for (int i = 0; i < arr.Length; i++)
        { 
            if(arr[i]==number)
            {
                counter++;
            }
        }
        return counter;
    }
    
    static void Main()
    {
        double[] myArr = { 45, 2,33, -7,2, 2.3, 2, -7, 2.3,-7.6,8,-66.3,2,-7};
        double myNum = 2.3;
        double myNumTest = -7;
        int result =RepeatedNumber(myArr, myNum);
        int resultTest = RepeatedNumber(myArr, myNumTest);
        for (int i = 0; i < myArr.Length; i++)
        {
            Console.Write("{0}",myArr [i]);
            if(i!=myArr.Length-1)
            {
                Console.Write("; ");
            }
        }
        Console.WriteLine();
        Console.WriteLine ("The number {0} is repeted {1} times.", myNum, result);
        Console.WriteLine("The number {0} is repeted {1} times.", myNumTest, resultTest);
    }
}
