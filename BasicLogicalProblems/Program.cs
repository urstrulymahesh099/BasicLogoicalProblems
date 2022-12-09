
using System;
namespace BasicLogicalProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Logical Problems ");
            Console.WriteLine("select options "+"\n"+"1.Fibonacci_Series:"+"\n"+ "2.PerfectNumber :" + "\n" + "3.PrimeNumber :" + "\n" + "4.ReverseNumber" + "\n" + "5.CouponNumber\n6.DayOfWeek\n7.TemperatureConversion");
            while (true)
            { 
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                { 
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("*********Fibonacci_Series*********");                        
                        Fibonacci_Series fibb = new Fibonacci_Series();
                        fibb.Fibb();
                        Console.ResetColor();
                        Console.WriteLine("Please select next option");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("*********PerfectNumber*********");
                        PerfectNumber perfect = new PerfectNumber();
                        perfect.Perfect();
                        Console.ResetColor();
                        Console.WriteLine("Please select next option");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("*********PrimeNumber*********");
                        PrimeNumber.CheckPrime(20);
                        Console.ResetColor();
                        Console.WriteLine("Please select next option");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("*********ReverseNumber*********");
                        ReverseNumber.Reverse();
                        Console.ResetColor();
                        Console.WriteLine("Please select next option");
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("*********CouponNumber*********");
                        CouponNumber.GenerateCoupon();
                        Console.ResetColor();
                        Console.WriteLine("Please select next option");
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("*********DayOfWeek*********");
                        DayOfWeek.WeekDate();
                        Console.ResetColor();
                        Console.WriteLine("Please select next option");
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine("*********ForegroundColor*********");
                        TemperatureConversion.Temp();
                        Console.ResetColor();
                        Console.WriteLine("Please select next option");
                        break;
                    default:
                        Console.WriteLine("please try again........");
                        break;
                }

            }
        }
    }
}