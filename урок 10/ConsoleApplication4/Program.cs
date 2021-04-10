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
           
            
          


            

            //далее 1.15 е
            Console.WriteLine("Напишите свое число СЭР");
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число c");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            

            double b5 = (-b + Math.Sqrt(Math.Pow(b,2)-4*a*c))/(a*2);



            Console.WriteLine("Решебник Котельникова. ответ:" + b5);
            Console.ReadKey();

        }
    }
}
