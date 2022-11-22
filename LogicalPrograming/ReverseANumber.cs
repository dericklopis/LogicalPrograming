using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    internal class ReverseANumber
    {
        public static void Reverse()
            {
                int reverse = 0, rem;
                Console.Write("Enter the number to be Reversed: ");
                int N= int.Parse(Console.ReadLine());
                while (N!=0)
                {
                   rem=N%10;
                   reverse=reverse*10+rem;
                   N/=10;
                }
                Console.Write("Reversed Number: "+reverse);
                Console.ReadLine();
        }
    }
}
