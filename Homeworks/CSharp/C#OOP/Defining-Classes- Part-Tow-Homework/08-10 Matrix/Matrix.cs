namespace _08_10_Matrix
{
    using System;
    using System.Collections.Generic;

    class Matrix<T> where T : struct, IComparable
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rowInput, int colInput)
        {
            this.Rows = rowInput;
            this.Cols = colInput;
            matrix = new T[rows, cols];
        }
        public int Rows
        {
            get { return this.rows; }
            set
            {
                if (value > 0 && value < int.MaxValue)
                    rows = value;
                else
                {
                    throw new ArgumentException("Rows must be between 1 and  2,147,483,647");
                }
            }
        }
        public int Cols
        {
            get { return this.cols; }
            set
            {
                if (value > 0 && value < int.MaxValue)
                {
                    this.cols = value;
                }
                else
                {
                    throw new ArgumentException("Cols must be between 1 and  2,147,483,647");
                }
            }
        }
        public T this[int rowInput, int colInput]
        {
            get
            {
                return matrix[rowInput, colInput];
            }
            set
            {
                if (rowInput >= 0 && rowInput < int.MaxValue && colInput >= 0 && colInput < int.MaxValue)
                {
                    matrix[rowInput, colInput] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Rows and Cols must be between 1 and  2,147,483,647");
                }
            }
        }
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMtrix)
        {
            Matrix<T> addition = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);
            if (firstMatrix.Rows == secondMtrix.Rows && firstMatrix.Cols == secondMtrix.Cols)
            {
                for (int row = 0; row < firstMatrix.Rows; row++)
                {
                    for (int col = 0; col < firstMatrix.Cols; col++)
                    {

                        dynamic currentElementFirst = firstMatrix[row, col];
                        dynamic currentElementSecond = secondMtrix[row, col];
                        addition[row, col] = currentElementFirst + currentElementSecond;
                    }
                }
            }
            else
            {
                throw new ArgumentException("Both  matrix must be same size");
            }

            return addition;
        }
        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondmatrix)
        {
            Matrix<T> substraction = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);
            if (firstMatrix.Rows == secondmatrix.Rows && firstMatrix.Cols == secondmatrix.Cols)
            {
                for (int row = 0; row < firstMatrix.Rows; row++)
                {
                    for (int col = 0; col < firstMatrix.Cols; col++)
                    {
                        dynamic currentElementFirst = firstMatrix[row, col];
                        dynamic currentElementSecond = secondmatrix[row, col];
                        substraction[row, col] = currentElementFirst - currentElementSecond;
                    }
                }
            }
            else
            {
                throw new ArgumentException(" Both matrix must be same size");
            }

            return substraction;
        }
        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            Matrix<T> product = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);
            if (firstMatrix.Cols == secondMatrix.Rows)
            {
                for (int row = 0; row < firstMatrix.Rows; row++)
                {
                    for (int col = 0; col < secondMatrix.Cols; col++)
                    {
                        dynamic value = 0;
                        product[row, col] = value;
                        for (int i = 0; i < firstMatrix.Cols; i++)
                        {
                            dynamic currentElementFirst = firstMatrix[row, i];
                            dynamic currentElementSecond = secondMatrix[i, col];
                            product[row, col] += currentElementFirst * currentElementSecond;
                        }
                    }
                }
            }
            else
            {
                throw new ArgumentException(" The colums of first matrix must be equal to rows of second matrix");
            }
            return product;
        }
        public static bool operator true(Matrix<T> matrix)
        {
            dynamic value = 0;
            bool nonZeroElement = false;
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] != value)
                    {
                        nonZeroElement = true;
                    }
                    else
                    {
                        nonZeroElement = false;
                    }
                }
            }
            return nonZeroElement;
        }
        public static bool operator false(Matrix<T> matrix)
        {
            dynamic value = 0;
            bool nonZeroElement = true;
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] == value)
                    {
                        nonZeroElement = false;
                    }
                    else
                    {
                        nonZeroElement = true;
                    }
                }
            }
            return nonZeroElement;
        }
        public static void PrintMatrix(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    Console.Write("{0,5}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
