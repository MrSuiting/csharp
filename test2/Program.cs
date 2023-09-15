
internal class Program
{
    private static void Main(string[] args)
    {
        int number = 123;
        int result = 0;
        int firstDig, secDig, thirdDig, fourDig, fifthDig = 0;

        if (number.ToString().Length == 5)
        {
            firstDig = number / 10000 % 10;
            Console.WriteLine(firstDig);

            secDig = number / 1000 % 10;
            Console.WriteLine(secDig);

            thirdDig = number / 100 % 10;
            Console.WriteLine(thirdDig);

            fourDig = number / 10 % 10;
            Console.WriteLine(fourDig);

            fifthDig = number % 10;
            Console.WriteLine(fifthDig);

            //Console.WriteLine("Trafalgure Square");
            if (firstDig == fifthDig && secDig == fourDig)
            {
                Console.WriteLine("Палиндром елки-палки!");
            }
            else
            {
                Console.WriteLine("Не, это не палиндром");
            }
        }
        else
        {
            Console.WriteLine("Length of number should be 5");
        }




        // int[] arrDig = new int[5]; //массив, в котор. значения типа int[]; имя массива arrDig; инициализируем new на длину int[5]

        // arrDig = number.ToArray();

        // var number = new List<int>();

        //var intList = number.Count().ToList();

        //Console.WriteLine(arrDig);







        // while (number != 0)
        // {
        //     result += number % 10;
        //     number /= 10;
        //     Console.WriteLine(number);
        // }
    }
}