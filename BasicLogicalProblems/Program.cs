
using System;
namespace BasicLogicalProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Problems ");
            Console.WriteLine("select options "+"\n"+"1.Fibonacci_Series:");
            while (true)
            { 
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Fibonacci_Series fibb = new Fibonacci_Series();
                        fibb.Fibb();
                        break;
                    default:
                        Console.WriteLine("please try again........");
                        break;
                }

            }
        }
    }
}