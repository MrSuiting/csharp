Console.Write("Number A: ");
int a = Convert.ToInt32(Console.ReadLine());
int len = Length(a);
Console.Write($"Sum of digits in number {a} is: {Sum(a, len)}");

int Length(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

int Sum(int a, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += a % 10;
        a /= 10;
    }
    return sum;
}