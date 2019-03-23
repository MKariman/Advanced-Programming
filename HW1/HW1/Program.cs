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
            int max = 0;
            for (int n = 0; n < x.Length; n++)
                x[n] = Convert.ToInt16(Console.ReadLine());
            max = x[9];
            for(int i=8;i>=0;i--)
            if (x[i] > max)
                max = x[i];
            Console.WriteLine("in meghdare maximum hastesh : {0}",max);


            Console.ReadKey();

        }
    }
}
