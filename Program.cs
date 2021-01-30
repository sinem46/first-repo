using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ConsoleApp
{
    class Program

    {
        

        static double timetosec(double h, double m, double s)
        {
            double time = h * 60 * 60 + m * 60 + s;
            return time;
        }

        static double mtomi(double m)
        {
            double mili = m * 0.00062137;
            return mili;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете разстояние в метри:");
            double Mtr = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете час:");
            double h= double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете минути:");
            double minuti = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете секунди:");
            double s = double.Parse(Console.ReadLine());
            
            Console.WriteLine(Mtr / timetosec(h, minuti, s));

            
            Console.WriteLine("Скоростта в метри/секунди {0}", Mtr / s);
            Console.WriteLine("Скоростта в мили/час {0}", mtomi(Mtr) / h);
            Console.WriteLine("Скоростта в км/час {0}", (Mtr* 0.001) / h);

        }
    }
}
