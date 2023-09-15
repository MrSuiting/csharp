// Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int FindSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int num = WorkWithUser("Введите число А: ");
int summ = FindSum(num);

int num1 = WorkWithUser("Введите число B: ");
int summ1 = FindSum(num1);

int num2 = WorkWithUser("Введите число C: ");
int summ2 = FindSum(num2);

Console.WriteLine($"{summ}, {summ1}, {summ2} сумма сумм {summ + summ1 + summ2}");