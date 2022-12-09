using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProblems
{
    public class DayOfWeek
    {
        public static void WeekDate()
        {
            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            int month = 03;
            int day = 29;
            int y0 = year - ((14 - month) / 12);

            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);

            int m0 = month + 12 * ((14 - month) / 12) - 2;

            int d0 = (day + x + 31 * m0 / 12) % 7;
            Console.WriteLine("click options for day");
            int option=Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("*********DAY*********");
            Console.ResetColor();
            switch (option)

            {
                case 0:
                    Console.WriteLine("sunday");
                    break;
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thrusday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
            }
            Console.WriteLine("click options for Moths");
            int months = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("*********MONTH*********");
            Console.ResetColor();
            switch (months)

            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
            }

            Console.WriteLine("Calculating year :"+x+"/"+m0+"/"+ d0);
        }
    }
}
