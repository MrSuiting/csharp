internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Input 2 numbers");

        int var1 = int.Parse(Console.ReadLine()!);
        int var2 = int.Parse(Console.ReadLine()!);

        if (var1 > var2)
        {
            Console.WriteLine($"Number {var1} is bigger than {var2}");
        }
        else if (var1 = var2)
        {
            Console.WriteLine($"Numbers {var1} & {var2} are equal");
        }
        else
        {
            Console.WriteLine($"Number {var2} is bigger than {var1}");
        }
    }
}