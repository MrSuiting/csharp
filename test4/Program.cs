using System;

public class Answer
{
    static void ShowCube(int N)
    {
        // Введите свое решение ниже

        int i, cube = 0;
        for (i = 1; i <= N; i++)
        {
            cube = i * i * i; //(int)Math.Pow(N, 3);
            Console.WriteLine(cube);
        }



        // int k3 = 1;
        // for(int i = 1; i <= N; i++)
        // {


        //     //k3++;
        //     k3 = i * i * i;
        //     Console.WriteLine(k3);
        //     //return k3;
        // }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int N;

        if (args.Length >= 1)
        {
            N = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 5;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}