using System;

class SequenceNMatrix
{
    static void Main()
    {
        /* •	We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets 
             of several neighbour elements located on the same line, column or diagonal.
           • Write a program that finds the longest sequence of equal strings in the matrix.*/

        string[,] matrix ={
                            {"ha","fifi","ho","hi"},
                            {"fo","ha","hi","xx"},
                            {"xxx","ha","ha","xx"},
                          };
        string bestSeq = string.Empty;
        int bestLenth = 0;
        int counter = 1;

        //finding sequence from left to right
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1) - 1; c++)
            {
                if (matrix[r, c] == matrix[r, c + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (bestLenth < counter)
                {
                    bestLenth = counter;
                    bestSeq = matrix[r, c];
                }
            }
        }
        counter = 1;
        //finding sequence down
        for (int c = 0; c < matrix.GetLength(1); c++)
        {
            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                if (matrix[r, c] == matrix[r + 1, c])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (bestLenth < counter)
                {
                    bestLenth = counter;
                    bestSeq = matrix[r, c];
                }
            }
        }
        counter = 1;
        //diagonal to right
        for (int c = 0; c < matrix.GetLength(1); c++)
        {
            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                for (int m = r, n = c; m < (matrix.GetLength(0) - 1) && n < (matrix.GetLength(1) - 1); m++, n++)
                {
                    if (matrix[m, n] == matrix[m + 1, n + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (bestLenth < counter)
                    {
                        bestLenth = counter;
                        bestSeq = matrix[m, n];
                    }
                }
            }
        }
        counter = 1;
        //diagonali to left
        for (int c = matrix.GetLength(1) - 1; c > 0; c--)
        {
            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                for (int m = r, n = c; m < (matrix.GetLength(0) - 1) && n > 0; m++, n--)
                {
                    if (matrix[m, n] == matrix[m + 1, n - 1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (bestLenth < counter)
                    {
                        bestLenth = counter;
                        bestSeq = matrix[m, n];
                    }
                }
            }
        }
        //printing result
        for (int k = 0; k < bestLenth; k++)
        {
            Console.Write("{0}", bestSeq);
            if (k != bestLenth - 1)
                Console.Write(", ");
        }
        Console.WriteLine();
    }
}

