internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Give me M:  ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Give me N:  ");
        int n = Convert.ToInt32(Console.ReadLine());

        int akkerman(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else if (n == 0)
                return akkerman(m - 1, 1);
            else
                return akkerman(m - 1, akkerman(m, n - 1));
        }

        Console.Write($"Akkerman function give us next value: {akkerman(m, n)} ");
    }
}