using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int fNum;
        int sNum;

        Console.Write("1st number is: ");
        fNum = int.Parse(Console.ReadLine()!);
        Console.Write("Digit to show in position: ");
        sNum = int.Parse(Console.ReadLine()!);

        if (sNum == 0)

            switch (sNum)
            {
                case 0:

            }

        Console.WriteLine("Number entered is: " + fNum);
        Console.WriteLine("Digit position selected is: " + sNum);
    }
}