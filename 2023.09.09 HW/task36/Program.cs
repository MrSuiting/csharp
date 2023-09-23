// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19

Console.Write("Quantity of elements in array:  ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void array(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().Next(1, 9);
        Console.WriteLine(randomArray[i] + " ");
    }

}

int quan(int[] randomArray)
{
    int sum = 0;
    int i = 0;
    while (i < randomArray.Length)
    {
        sum = sum + randomArray[i];
        i = i + 2;
    }
    return sum;
}

array(a);
Console.Write($"Elements sum in odd positions : { quan(randomArray)}");