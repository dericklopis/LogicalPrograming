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
            Console.WriteLine("1:FibonacciSeries");
            string options = Console.ReadLine();
            switch (options)
            {
                case "1":
                    FibonacciSeries.Series();
                    break;
            }
            Console.ReadLine();
        }
    }
}