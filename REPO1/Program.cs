using System;

class LeapYearChecker
{
    static void Main()
    {
        Console.Write("Введите год: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) // &&- и ; ||- или
        {
            Console.WriteLine(year + "  — високосный год.");
        }
        else
        {
            Console.WriteLine(year + "  - не високосный.");
        }
    }
}