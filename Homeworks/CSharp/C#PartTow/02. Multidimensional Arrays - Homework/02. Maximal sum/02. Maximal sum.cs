using System;

class MaximalSum
{
    static void Main()
    {
        //•	Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.


        int[,] marrix = {
                            {77, 88,  99,   55,  66,   3, 27},
                            {33, -44,  93,  -77,  -9,  -6, 36},
                            { 7,  8, -99,  155, -66,  53, 21},
                            {13, 14,  -3,  -7,   19,  16, 36},
                            {77, 88,  99,  55,   66,   3, 44},
                        };

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        int tempSum = 0;

        for (int r=0; r<marrix.GetLength(0)-2;r++)
        {
            for(int c=0; c<marrix.GetLength(1)-2;c++)
            {
                tempSum = marrix[r, c]+marrix[r, c+1]+marrix[r, c+2]
                        +marrix[r+1, c]+ marrix[r+1, c+1]+ +marrix[r+1, c+2]
                         +marrix[r+2, c]+marrix[r+2, c+1]+marrix[r+2, c+2];

                if(tempSum>bestSum)
                {
                    bestSum=tempSum;
                    bestRow=r;
                    bestCol=c;
                }
            }
        }

        Console.WriteLine("The best sum start from {0} and is {1}. ", marrix[bestRow,bestCol],bestSum);
    }
}

