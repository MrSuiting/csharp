internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Value b1:  ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Value k1:  ");
        double k1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Value b2:  ");
        double b2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Value k2: ");
        double k2 = Convert.ToDouble(Console.ReadLine());

        double x = -(b1 - b2) / (k1 - k2);
        double y = k1 * x + b1;

        Console.Write($"Crossing point is: [{x},{y}]");
    }
}