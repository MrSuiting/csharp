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
                    Console.Write($"{ array[i, j]} ");
        }
        Console.WriteLine();
}
}

randarr(y, x);
        Console.WriteLine("Default generated array:  ");
        output(randomArray);

        // Функция, считающая сумму элементов в строке
        int SumLine(int[,] array, int i)
        {
            int sum = array[i, 0];
            for (int j = 1; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            return sum;
        }

        int minimal = 1;
        int sum = SumLine(randomArray, 0);
        for (int i = 1; i < randomArray.GetLength(0); i++)
        {
            if (sum > SumLine(randomArray, i))
            {
                sum = SumLine(randomArray, i);
                minimal = i + 1;
            }
        }
        Console.WriteLine($"Lowest value line is {minimal}");
    }
}