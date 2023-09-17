internal class Program
{
    private static void Main(string[] args)
    {
        int numA, numB, numR, i = 0;

        Console.WriteLine("Enter numbers \"A\" to be raised to power \"B\"");
        numA = Convert.ToInt32(Console.ReadLine());
        numB = Convert.ToInt32(Console.ReadLine());

        if (numB < 1)
            Console.Write("Incorrect number");
        else
        {
            while (numB != 0)
            {
                numR = 1;
                numR = numR * numA;
                numB = numB - 1;
            }
            Console.WriteLine(numR);
        }

    }
}