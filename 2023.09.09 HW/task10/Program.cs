
int Proc_Message(string message)
{
    System.Console.Write(message);
    string var1 = Console.ReadLine();
    int var1_conv = Convert.ToInt32(var1);
    return var1_conv;
}

int var2 = Proc_Message("Pls, give 3 digit number here:  ");
if (var2 > 99 && var2 < 1000)
{
    int secDig = (var2 / 10) % 10;
    Console.WriteLine($"Secong digit in number {var2} is {secDig}");
}
else
    Console.WriteLine("Thus, this is not a correct 3 digit number. Repeat.");
    return 0;


