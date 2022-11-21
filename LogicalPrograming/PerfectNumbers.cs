using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    internal class PerfectNumbers
    {
        
        public static void PerfectNum()
        {
            int sum = 0, N;
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            N=num;
            for(int i=1 ; i<num ; i++)
            {
                if ( num % i == 0)
                {
                    sum = sum+i;
                }
            }
            if(sum==N)
            {
                Console.WriteLine("\n Entered number is a perfect number");
            }
            else
            {
                Console.WriteLine("\n Entered number is not perfect");
            }
            Console.ReadLine();
        }
    }        
}
