using System;
 
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] matrix = new int[2, 2];
            int[,] matrix2 = new int[2, 2];
            int[,] multiplyMatrix = new int[2, 2];
 
 
            fillMatrix(matrix,rnd);
            Console.WriteLine("Matrix 1 output:  ");
            printMatrix(matrix);
 
 
            fillMatrix(matrix2,rnd);
            Console.WriteLine("Matrix 2 output:  ");
            printMatrix(matrix2);
            multiPlyMatrix(matrix, matrix2,multiplyMatrix);
 
            Console.WriteLine("Matrix multiplication:  ");
            printMatrix(multiplyMatrix);
        }
 
 
 
 
        
        static void fillMatrix(int[,] matrix,Random rnd)
        { 
           
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(20);
                }
                
            }
        }
        static void printMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]+ " ");
                }
                Console.WriteLine();
            }
 
        }
        static void multiPlyMatrix(int[,] matrix, int[,] matrix2, int[,] multMatrix)
        {
 
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    multMatrix[i, j] = matrix2[i, j] * matrix[i, j];
                }
 
            }
        }
    }
}