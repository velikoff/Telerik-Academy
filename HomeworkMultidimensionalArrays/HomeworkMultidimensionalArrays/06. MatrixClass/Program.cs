using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.MatrixClass
{
    class Program
    {
        static void Main()
        {
            // testing the class functionality
            int[,] matrix1 = new int[5, 5]{
            {5,3,5,8,1},
            {6,8,1,-5,9},
            {3,-5,8,-1,-3},
            {2,0,-7,3,-4},
            {5,-1,2,7,3}};
            int[,] matrix2 = new int[5, 5]{
            {1,5,5,-8,0},
            {2,8,1,5,1},
            {-2,5,8,-6,5},
            {2,4,-7,9,-2},
            {0,4,-3,-6,1}};
            Matrix m1 = new Matrix(matrix1);
            Matrix m2 = new Matrix(matrix2);

            Console.WriteLine("Matrix 1");
            Console.WriteLine(m1);

            Console.WriteLine("Matrix 2");
            Console.WriteLine(m2);

            Console.WriteLine("Adding Matrix");
            Console.WriteLine(m1 + m2);

            Console.WriteLine("Substracting Matrix");
            Console.WriteLine(m1 - m2);

            Console.WriteLine("Multiplying Matrix");
            Console.WriteLine(m1 * m2);

            Console.WriteLine("Matrix Indexer");
            Console.WriteLine(m1[2, 2]);
        }

    }

    class Matrix
    {
        private int[,] matrix;
        private int rows;
        private int columns;

        public Matrix(int x, int y)
        {
            matrix = new int[x, y];
            this.rows = x;
            this.columns = y;
        }
        public Matrix(int[,] matrix)
        {
            this.matrix = matrix;
            this.rows = matrix.GetLength(0);
            this.columns = matrix.GetLength(1);
        }
        //indexer
        public int this[int x, int y]
        {
            get { return matrix[x, y]; }
            set { matrix[x, y] = value; }
        }

        // adding
        public static Matrix operator +(Matrix matrixA, Matrix matrixB)
        {
            if (matrixA.rows != matrixB.rows && matrixA.columns != matrixB.columns)
            {
                throw new System.ArgumentException("Matrix must be with same dimentions", "original");
            }
            Matrix matrixC = new Matrix(matrixA.rows, matrixA.columns);
            for (int i = 0; i < matrixA.rows; i++)
            {
                for (int j = 0; j < matrixA.columns; j++)
                {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            return matrixC;
        }
        // substracting
        public static Matrix operator -(Matrix matrixA, Matrix matrixB)
        {
            if (matrixA.rows != matrixB.rows && matrixA.columns != matrixB.columns)
            {
                throw new System.ArgumentException("Matrix must be with same dimentions", "original");
            }
            Matrix matrixC = new Matrix(matrixA.rows, matrixA.columns);
            for (int i = 0; i < matrixA.rows; i++)
            {
                for (int j = 0; j < matrixA.columns; j++)
                {
                    matrixC[i, j] = matrixA[i, j] - matrixB[i, j];
                }
            }
            return matrixC;
        }
        //multiplying
        public static Matrix operator *(Matrix matrixA, Matrix matrixB)
        {
            if (matrixA.rows != matrixB.columns && matrixA.columns != matrixB.rows)
            {
                throw new System.ArgumentException("Matrix must be with same dimentions", "original");
            }
            Matrix matrixC = new Matrix(matrixA.rows, matrixA.columns);
            for (int i = 0; i < matrixA.rows; i++)
            {
                for (int j = 0; j < matrixB.columns; j++)
                {
                    for (int row = 0; row < matrixA.columns; row++)
                    {
                        matrixC[i, j] += matrixA[i, row] * matrixB[row, j];
                    }
                }
            }

            return matrixC;
        }

        public override string ToString()
        {
            string str = String.Empty;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 0)
                    {
                        str += "|".PadRight(3);
                    }
                    str += Convert.ToString(matrix[i, j]).PadRight(3);
                    str += "|".PadRight(3);
                }
                str += "\n";
                for (int j = 0; j < rows; j++)
                {
                    str += "------";
                }
                str += "\n";
            }

            return str;
        }

    }

}
        
    

