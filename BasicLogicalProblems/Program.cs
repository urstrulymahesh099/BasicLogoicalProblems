
using System;
namespace BasicLogicalProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Logical Problems ");
            Console.WriteLine("select options "+"\n"+"1.Fibonacci_Series:"+"\n"+ "2.PerfectNumber :" + "\n" + "3.PrimeNumber :" + "\n" + "4.ReverseNumber" + "\n" + "5.CouponNumber");
            while (true)
            { 
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                { 
                    case 1:
                        Fibonacci_Series fibb = new Fibonacci_Series();
                        fibb.Fibb();
                        break;
                    case 2:
                        PerfectNumber perfect = new PerfectNumber();
                        perfect.Perfect();
                        break;
                    case 3:
                        PrimeNumber.CheckPrime(20);
                        break;
                    case 4:
                        ReverseNumber.Reverse();
                        break;
                    case 5:
                        CouponNumber.GenerateCoupon();
                        break;
                    default:
                        Console.WriteLine("please try again........");
                        break;
                }

            }
        }
    }
}