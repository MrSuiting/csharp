internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Let's check if the number is even");
        int var1 = int.Parse(Console.ReaLine()!);
        if (var1 % 2 == 0)
        {
            Console.WriteLine($"Number {var1} is even");
        }
        else if (var1 % 2 != 0)
        {
            Console.WriteLine($"Number {var1} is odd");
        }
        else
        {
            Console.WriteLine("Number is unknown");
        }

    }
}