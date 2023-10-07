internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Give me that number:  ");
        int m = Convert.ToInt32(Console.ReadLine());
        void recur(int m)
        {
            //if (m > 0){
                if (m % 2 == 0)
                {
                    Console.Write($"{m}, ");
                }
                recur(m - 1);
            //}

        }
        recur(m);
    }
}