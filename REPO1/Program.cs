//using System;

//public class IsLeapYear
//{
//    public static void Main()
//    {
//        for (int year = 1994; year <= 3000; year++)
//        {
//            if (DateTime.IsLeapYear(year))
//            {
//                Console.WriteLine("{0} is a leap year.", year);
//                DateTime leapDay = new DateTime(year, 2, 29);
//                DateTime nextYear = leapDay.AddYears(1);
//                Console.WriteLine("   One year from {0} is {1}.",
//                                  leapDay.ToString("d"),
//                                  nextYear.ToString("d"));
//            }
//        }
//    }
//}
using System;

class LeapYearChecker
{
    static void Main()
    {
        Console.Write("Введите год: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 4 == 0/*; year % 100 != 0) (year % 400 == 0))*/)
        {
            Console.WriteLine(year + "  — високосный год.");
        }
        else
        {
            Console.WriteLine(year + "  - не високосный.");
        }
    }
}