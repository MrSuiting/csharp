int proc_Message(string message)
{
    Console.Write(message);
    string var1 = Console.ReadLine();
    int var1_conv = Convert.ToInt32(value);
    return var1_conv;
}

int CheckThree(int var2)
{
    if (var2 > 99 && var2 < 1000)
    {
        var2_3dig = (var2 / 10) % 10;
        Console.WriteLine($"The 3d digit in {var2} is {var2_3dig}");
    }
    else if (var2 < 100)
    {
        Console.WriteLine("The number you've enetred has less than 3 digits");
    }
}

int var2 = proc_Message("Pls, give a number here:  ")
if (CheckThree(var2))
{
    Console.WriteLine(CheckThree(var2))
}