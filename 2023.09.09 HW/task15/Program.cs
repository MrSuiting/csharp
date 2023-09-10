int proc_Message(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekDay(int number)
{
    if (number > 0 && number <=7)
    {
        return true;
    }
    Console.WriteLine("This is not a valid number for week");
    return false;
}

int weekDay = proc_Message("Give a day number in a week here:  ");
if (ValidateWeekDay(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("It's a weekend");
    }
    else
    {
        Console.WriteLine("It's a work day");
    }
}