using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет мир,а я сережа");
            Console.ReadKey();

            Console.WriteLine("Как тебя зовут???");
            string myName = Console.ReadLine(); // ЧУВАК ЗАЧЕМ ТЫ НА ЭТО ПОДПИСАЛСЯ ТЫ ШО ЗАБЫЛ ТУТ?

            

          

            int age, weight, height;
            Console.WriteLine("Сколько тебе лет, ноунейм?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько ты весишь быдлан?");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Какой у тебя рост дюймовочка?");
            height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Здарова," + myName);
            Console.WriteLine("Ваш возраст," + age+" лет");
            Console.WriteLine("Ваш ростик," + height/100.0+" метров");
            Console.WriteLine("Здарова," + weight*1000+" грамм");

           Console.ReadKey(); // ЭТО КОРОЧЕ ЗАКРЫЛОСЬ ЧТОБ


        }
    }
}
