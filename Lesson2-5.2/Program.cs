using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_5._2
{
    class Program
    {
        static void CreateMatrix(ref int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        static void Max(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (max < array[i + 1])
                    max = array[i + 1];
            }
            Console.WriteLine($"Max = {max}");
        }
        static void Min(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (min > array[i + 1])
                    min = array[i];
            }
            Console.WriteLine($"Min = {min}");
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размерность масива : ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            CreateMatrix(ref array);

            Max(array);
            Min(array);

            Console.ReadKey();
        }
    }
}
