using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProblems
{
    internal class Fibonacci_Series
    {
        int n1 = 0, n2 = 1, n3, i;

        public void Fibb()
        {
            Console.WriteLine("Enetr the number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Print First numbers "+"\n"+ n1 +"\n"+"second number"+"\n"+ n2 );
            Console.WriteLine("and remaining numbers are: ");
            for (i=2;i<number;i++)
            {
                n1 = n2;
                n2 = n3;
                n3 = n1 + n3;
                Console.WriteLine(n3);
            }

        }
    }
}
