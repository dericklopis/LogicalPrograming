using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    internal class WatchStop
    {
        public static void time()
        {
            int E=0;
            Console.WriteLine("Press 1 to Start");
            int N=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Press 2 to Stop");
            if (N==1)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                while (E != 2)
                {
                    E = int.Parse(Console.ReadLine());
                }
                stopwatch.Stop();
                Console.WriteLine("The elpsed time is :" + stopwatch.Elapsed);
                Console.ReadLine();
            }          
        }
    }
}
