internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Give me quantity of lines \"Y\" in array:  ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Give me quantity of columns \"X\" in array:  ");
        int x = Convert.ToInt32(Console.ReadLine());
        int[,] randomArray = new int[y, x];

        void randarr(int y, int x)
        {
            int i, j;
            Random rand = new Random();
            for (i = 0; i < y; i++)
            {
                for (j = 0; j < x; j++)
                {
                    randomArray[i, j] = rand.Next(1, 9);
                }
            }
        }

        void output(int[,] array)
        {
            int i, j;
            for (i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

        }

        randarr(y, x);
        Console.WriteLine("Default random generated array:  ");
        output(randomArray);


        void sorted(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
}
}

sorted(randomArray);
        Console.WriteLine("Sorted array by value:  ");
        output(randomArray);
    }
}