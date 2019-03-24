using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class Program
    {
        public static string Maximum()
        {
            int[] x = new int[10];
            int max = 0;
            Console.WriteLine("Lotfan 10 adad vared konid :");
            for (int n = 0; n < x.Length; n++)
            {
                Console.Write("adade {0} :", n + 1);
                x[n] = Convert.ToInt16(Console.ReadLine());
            }
            max = x[9];
            for (int i = 8; i >= 0; i--)
                if (x[i] > max)
                    max = x[i];
            return Convert.ToString(max);
        }
        public static string Tarikh()
        {
            DateTime myDate = DateTime.Now;
            return myDate.ToShortDateString();
        }
        static void Main(string[] args)
        {
            Console.Write("Menu :\n1-Maximum chie?\n2-Tarikhe emruz chie?\nLotfan yek gozine ra entekhab konid : ");
            int menu = Convert.ToInt16(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("\n\n\nmaximum meghdari ke vared shod ine : {0}",Maximum());
                    break;
                case 2:
                    Console.WriteLine("\n\n\nin tarikhe emrooze : {0}",Tarikh());
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
        
    }
}
