using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовое значение оценки");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 2: { 
                            Console.WriteLine("Неуд");
                            break;
                    }
                 case 3:
                    {
                        Console.WriteLine("Уд");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Хорошо");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Отлично");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка ввода данных");
                        break;
                    }
               }

            Console.ReadKey();

            }        
    }
        
}
