using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_5.add2
{
    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek day = new DayOfWeek();
            Console.Write("Введите номер дня недели : ");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine(day[i]);

            Console.ReadKey();
        }
    }
}
