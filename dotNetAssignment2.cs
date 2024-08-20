// Find valid date (MMDDYYYY) from string.
// For example :-
// Hdjsh asd2324234jghjsd hjsdg sdhk 12212021 idf32432 32423 d34234jh dfh
using System;

class Program
{
    static void Main()
    {
        string input = "Hdjsh asd2324234jghjsd hjsdg sdhk 12212021 idf32432 32423 d34234jh dfh";
        FindAndPrintValidDates(input);
    }

    static void FindAndPrintValidDates(string input)
    {
        for (int i = 0; i <= input.Length - 8; i++)
        {
            string candidate = input.Substring(i, 8);
            if (IsValidDate(candidate))
            {
                Console.WriteLine("Valid Date Found: " + candidate);
            }
        }
    }

    static bool IsValidDate(string dateStr)
    {
        if (dateStr.Length != 8)
            return false;
        string monthStr = dateStr.Substring(0, 2);
        string dayStr = dateStr.Substring(2, 2);
        string yearStr = dateStr.Substring(4, 4);
        if (!int.TryParse(monthStr, out int month) ||
            !int.TryParse(dayStr, out int day) ||
            !int.TryParse(yearStr, out int year))
        {
            return false;
        }
        if (month < 1 || month > 12)
            return false;
        if (day < 1 || day > 31)
            return false;
        if (month == 2) 
        {
            if (IsLeapYear(year) && day > 29)
                return false;
            if (!IsLeapYear(year) && day > 28)
                return false;
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            if (day > 30)
                return false;
        }

        return true;
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
