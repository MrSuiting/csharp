internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Let's build a row till N number");
        int var1 = int.Parse(Console.ReadLine());

        if (var1 % 2 == 0)
        {
            for (int i = 0; i < var1; i = i + 2)
            {
                Console.WriteLine(var1);
                var1 = var1 + 2;
            }

        }
        else if (var1 % 2 == 1)
        {
            var1 = var1 + 1;
            for (int i = 0; i <= var1; i = i + 2)
            {
                Console.WriteLine(var1);
                var1 = var1 + 2;
            }
        }
        else
        {
            Console.WriteLine("Nothing happened");
        }

    {







        // for (int i = 0; i <= var1; i = i + 2)
        // {

        //     Console.WriteLine($"Number row is {}");
        //     var1 = var1 + 2;
        // }
        
        // else if (var1 % 2 == 1)

        // for (int i = 0; i <= var1; i++)
        // {
        //     Console.WriteLine($"Number row is {}");
        //     var1 = var1 + 1;
        // }


    }
    Console.WriteLine("Calculation is done");
    }
}