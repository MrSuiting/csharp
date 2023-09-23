//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Quantity of elements in array:  ");
        int a = Convert.ToInt32(Console.ReadLine());
        double[] randomArray = new double[a];

        void array(int a)
        {
            Random rand = new Random();
            for (int i = 0; i < a; i++)
            {
                randomArray[i] = rand.NextDouble();
                Console.WriteLine($"{ randomArray[i]:F2}");
}

}

double diff(double[] randomArray)
        {
            double min = randomArray[0];
            double max = randomArray[0];
            int i = 1;
            while (i < randomArray.Length)
            {
                if (max < randomArray[i])
                    max = randomArray[i];
                if (min > randomArray[i])
                    min = randomArray[i];
                i = i + 1;
            }
            return max - min;
        }

        array(a);
        Console.Write($"Разница между максимальным и минимальным элементов массива: { diff(randomArray):F2}");
    }
}