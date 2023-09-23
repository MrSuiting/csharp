// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Elements in array. Quantity: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int[] randomArray = new int[a];

        void array(int a)
        {
            for (int i = 0; i < a; i++)
            {
                randomArray[i] = new Random().Next(99, 999);
                Console.Write(randomArray[i] + " ");
            }

        }

        int quan(int[] randomArray)
        {
            int digs = 0;
            for (int i = 0; i < randomArray.Length; i++)
            {
                if (randomArray[i] % 2 == 0)
                    digs = digs + 1;
            }
            return digs;
        }

        array(a);
        Console.Write($"Quantity of even numbers: {quan(randomArray)}");
    }
}