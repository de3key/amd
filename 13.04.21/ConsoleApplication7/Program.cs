using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Число намбер уан");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Число намбер ту");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Число намбер фри");
            double c = Convert.ToDouble(Console.ReadLine());

           if ( a > (b + c) &  b < (a + c) & c < (a + b))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(b);
            }

            Console.ReadKey(); 
        }
    }
}
