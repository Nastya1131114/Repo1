using System;

class LeapYearChecker
{
    static void Main()
    {
        Console.Write("Введите год, который вас интересует: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) // &&- и ; ||- или
        {
            Console.WriteLine(year + "  — этот год високосный ");
        }
        else
        {
            Console.WriteLine(year + "  - этот год не високосный ");
        }
    }
}