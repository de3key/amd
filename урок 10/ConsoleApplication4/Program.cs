using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {







            //далее 1.17 б
            Console.WriteLine("Напишите свое число СЭР");
            Console.WriteLine("Введите число x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число x");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Math.Sqrt(Math.Pow(x, 2)) + (Math.Pow(x2, 2));
            Console.WriteLine("Ваш ответ:" +x3);
            Console.ReadKey();










        }
    }
}
