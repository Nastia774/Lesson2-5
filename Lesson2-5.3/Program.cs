using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_5._3
{
    class Program
    {
        static void CreateMatrix(ref int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
            }

        }
        static void Main(string[] args)
        {
            int[] array = new int[5];
            CreateMatrix(ref array);

            MyMatrix myMatrix = new MyMatrix(array);
            myMatrix.Write(array);
            myMatrix.Column();
            myMatrix.Line(2);

            Console.ReadKey();
        }
    }
}
