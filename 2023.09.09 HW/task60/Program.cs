internal class Program
{
    private static void Main(string[] args)
    {
        int[,,] Random3dArray(int field, int rows, int columns)
        {
            int[,,] newArray = new int[field, rows, columns]; //initializing
            for (int i = 0; i < field; i++) 
            {
                for (int j = 0; j < rows; j++)
                { for (int k = 0; k < columns; k++)
                { newArray[i, j, k] = i + j + k; }
                }
            }
            return newArray;
        }
        void Show3dArray(int[,,] array) // показываем двумерный массив
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write("[" + i + "," + j + "]" + array[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.Write("Input number of field:  "); 
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input number of rows:  ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input number of columns:  ");
        int l = Convert.ToInt32(Console.ReadLine());
        int[,,] array = Random3dArray(m, n, l);
        Show3dArray(array);
    }
}