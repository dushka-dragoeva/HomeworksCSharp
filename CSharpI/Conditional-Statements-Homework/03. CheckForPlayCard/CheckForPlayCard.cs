using System;

class CheckForPlayCard
{
    static void Main(string[] args)
    {
        //03.Classical play cards use the following signs to designate the card face: 
        //`2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints 
        //“yes” if it is a valid card sign or “no” otherwise. 
        Console.WriteLine("Please, enter a play card face :  ");
        string cardFace = Console.ReadLine();
        int cardNumber;
        Console.Write("Valid carg sign? -  ");
        if (int.TryParse(cardFace, out cardNumber))
        {
            bool check = (cardNumber >= 2 && cardNumber <= 10);
            if (check)
            {
                Console.WriteLine("YES");
            }
        }
        else
        {
            switch (cardFace)
            {
                case "A":
                case "J":
                case "D":
                case "K":
                    Console.WriteLine("YES"); break;
                default:
                    Console.WriteLine("NO!"); break;
            }
        }
    }
}
