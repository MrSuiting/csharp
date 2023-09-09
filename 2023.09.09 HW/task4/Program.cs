internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Give me 3 numbers");

        int var1 = int.Parse(Console.ReadLine());
        int var2 = int.Parse(Console.ReadLine());
        int var3 = int.Parse(Console.ReadLine());

        if (var1 > var2 && var1 > var3)
        {
            Console.WriteLine($"Number {var1} bigger than {var2} & {var3}");
        }
        else if (var2 > var1 && var2 > var3)
        {
            Console.WriteLine($"Number {var2} bigger than {var1} & {var3}");
        }
        else if (var3 > var1 && var3 > var2)
        {
            Console.WriteLine($"Number {var3} bigger than {var1} & {var2}");
        }
        else 
        {
            Console.WriteLine($"The numbers are equal or do not exist");
        }




    }
}