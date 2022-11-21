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
            Console.WriteLine("Enter First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter any number: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" " + num1, + num2);
            for (int i=2;i<=N; i++)
            {
                N=num1+num2;
                Console.WriteLine(" " + N);
                num1=num2;
                num2=N;
            }
            Console.ReadLine();
        }
    }
}
