using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    internal class FibonacciSeries
    {
        public static void Series()
         {
            int num=0;
            Console.WriteLine("Enter First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Repeat till number: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" " + num1, + num2);
            while (num <= N)
            {
                num=num1+num2;
                Console.WriteLine(" " + num);
                num1=num2;
                num2=num;
            }
            Console.ReadLine();
        }
    }
}
