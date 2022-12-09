
using System;
namespace BasicLogicalProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Logical Problems ");
            Console.WriteLine("select options "+"\n"+"1.Fibonacci_Series:"+"\n"+ "2.PerfectNumber :" + "\n" + "3.PrimeNumber :" + "\n" + "4.ReverseNumber" + "\n" + "5.CouponNumber\n6.DayOfWeek");
            while (true)
            { 
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                { 
                    case 1:
                        Fibonacci_Series fibb = new Fibonacci_Series();
                        fibb.Fibb();
                        Console.WriteLine("Please select next option");
                        break;
                    case 2:
                        PerfectNumber perfect = new PerfectNumber();
                        perfect.Perfect();
                        Console.WriteLine("Please select next option");
                        break;
                    case 3:
                        PrimeNumber.CheckPrime(20);
                        Console.WriteLine("Please select next option");
                        break;
                    case 4:
                        ReverseNumber.Reverse();
                        Console.WriteLine("Please select next option");
                        break;
                    case 5:
                        CouponNumber.GenerateCoupon();
                        Console.WriteLine("Please select next option");
                        break;
                    case 6:
                        DayOfWeek.WeekDate();
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