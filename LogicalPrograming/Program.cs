using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose one program from below options");
            Console.WriteLine("1:FibonacciSeries \n2:PerfectNumbers \n3:Prime numbers \n4:Reverse a number");
            string options = Console.ReadLine();
            switch (options)
            {
                case "1":
                    FibonacciSeries.Series();
                    break;
                case "2":
                    PerfectNumbers.PerfectNum();
                    break;
                case "3":
                    PrimeNumbers.Prime();
                    break;
                case "4":
                    ReverseANumber.Reverse();
                    break;
            }
            Console.ReadLine();
        }
    }
}