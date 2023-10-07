internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Number one value (M) is:  ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number two value (N) is:  ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum_range(int m, int n)
        {
            if (m == n)
                return n;
            else return m + sum_range(m + 1, n);
        }
        Console.Write($"Sum of numbers in range of M & N is: {sum_range(m, n)}");
    }
}