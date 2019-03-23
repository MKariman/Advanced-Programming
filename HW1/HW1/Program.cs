using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];
            for (int n = 0; n < x.Length; n++)
                   x[n] = Convert.ToInt16(Console.ReadLine());
            foreach (int n in x)
                Console.WriteLine(x[n-1]);
            Console.ReadKey();

        }
    }
}
