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
            //далее 1.17 а
            Console.WriteLine("Напишите свое число СЭР");
            Console.WriteLine("Введите число x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число x");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Math.Sqrt(Math.Pow(x, 2)) + (Math.Pow(x2, 2));
            Console.WriteLine("Ваш ответ:" + x3);
            Console.ReadKey();



            //далее 1.17 б
            Console.WriteLine("Напишите свое число пожалуйста");
            Console.WriteLine("Введите число x1");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число x3");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double x4 = x + x2 * x + x3 * x2 + x3;
            Console.WriteLine("Ваш ответ:" + x4);
            Console.ReadKey();


            //далее 1.17 в


            Console.WriteLine("Напиши свое число принцесса");
            Console.WriteLine("Введите число V");
            double v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число T");
            double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число T2");
            double t2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            double j = v * t + (a * Math.Pow(t2, 2) / 2);

            Console.WriteLine("Ваш ответ:" + j);
            Console.ReadKey();


            //далее 1.17 г
            Console.WriteLine("Напиши свое число юнный хакер");
            Console.WriteLine("Введите число m");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число v");
            double v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число g");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число h");
            double h = Convert.ToDouble(Console.ReadLine());
            double j = (m * Math.Pow(v, 2) / 2 + m * g * h);
            Console.WriteLine("Ваш ответ:" + j);
            Console.ReadKey();

            //далее 1.17 д

            Console.WriteLine("Я интеллект АНТОШКА");
            Console.WriteLine("Введите число R");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число R2");
            double r2 = Convert.ToDouble(Console.ReadLine());
            double r3 = 1 / r + 1 / r2;
            Console.WriteLine("Ваш ответ:" + r3);
            Console.ReadKey();

            //далее 1.17 е

            Console.WriteLine("Я интеллект АНТОШКА");
            Console.WriteLine("Введите число m");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число g");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            double j = m * g * Math.Cos(a);
            Console.WriteLine("Ваш ответ:" + j);
            Console.ReadKey();

        }
    }
}
