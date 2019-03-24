using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            Console.WriteLine("{0} or {1}",myDate.ToLongDateString(),myDate.ToShortDateString());
            Console.ReadKey();
        }
    }
}
