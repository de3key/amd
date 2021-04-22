using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите КОРОЧЕ ТУТ ЧТО ТО ЧТОБ Я РАДОВАЛСЯ");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("Понедельник");
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Вторник");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Cреда");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Четверг");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Пятница");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Суббота");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Отдыхаем зяблики");
                        break;
                    }

                    

            }
            Console.ReadKey();

        }
    }
}