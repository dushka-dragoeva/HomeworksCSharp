/*
 Problem 8. Matrix
Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
Problem 9. Matrix indexer
Implement an indexer this[row, col] to access the inner matrix cells.
Problem 10. Matrix operations
Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
Throw an exception when the operation cannot be performed.
Implement the true operator (check for non-zero elements).
Problem 11. Version attribute
Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
Apply the version attribute to a sample class and display its version at runtime.
 */
namespace _08_10_Matrix
{
    using System;
   
    [VersionAtribute(2,65)]
    
    class RunMatrix
    {
        static void Main()
        {
            var firstMatrix = new Matrix<int>(3, 4);
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    firstMatrix[i, j] = 10 + i + j;
                }
            }
            var secondMatrix = new Matrix<int>(3, 4);
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    secondMatrix[i, j] = 5 - i - j;
                }
            }
            var thirdMatrix = new Matrix<int>(4, 2);
            for (int i = 0; i < thirdMatrix.Rows; i++)
            {
                for (int j = 0; j < thirdMatrix.Cols; j++)
                {
                    thirdMatrix[i, j] = 16 + i + j;
                }
            }

            var additionMatrix = firstMatrix + secondMatrix;
            var sustractinMatrix = firstMatrix - secondMatrix;
            var productMatrix = firstMatrix * thirdMatrix;

            Console.WriteLine("First Matrix");
            Matrix<int>.PrintMatrix(firstMatrix);
            Console.WriteLine("Second Matrix");
            Matrix<int>.PrintMatrix(secondMatrix);
            Console.WriteLine("Addition of First Matrix and Second Matrix");
            Matrix<int>.PrintMatrix(additionMatrix);
            Console.WriteLine("Substraction of First Matrix and Second Matrix");
            Matrix<int>.PrintMatrix(sustractinMatrix);
            Console.WriteLine("Third Matrix");
            Matrix<int>.PrintMatrix(thirdMatrix);
            Console.WriteLine("Product of First Matrix and Third Matrix");
            Matrix<int>.PrintMatrix(productMatrix);

            Console.Write("First Matrix ");
            if (firstMatrix)
            {
                Console.WriteLine("doesn't conatain zero elements");
            }
            else
            {
                Console.WriteLine("conatains zero elements");
            }
            Console.Write("Second Matrix ");
            if (secondMatrix)
            {
                Console.WriteLine("doesn't conatain zero elements");
            }
            else
            {
                Console.WriteLine("conatains zero elements");
            }
            Type type = typeof(RunMatrix);
            object [] attr = type.GetCustomAttributes(false);
            foreach (var item in attr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
