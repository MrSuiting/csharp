internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("How much elements should be? Give quantity:  ");
        int m = Convert.ToInt32(Console.ReadLine());
        int[] Array = new int[m];

        void arr(int m)
        {
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Give elements one-by-one: {i + 1} ");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }

        }

        int quan(int[] Array)
        {
            int i = 0;
            int sum = 0;
            while (i < Array.Length)
            {
                if (Array[i] > 0)
                    sum = sum + 1;
                i = i + 1;
            }
            return sum;
        }

        arr(m);
        Console.Write($"Quantity of numbers bigger than zero is: { quan(Array)}");
    }
}