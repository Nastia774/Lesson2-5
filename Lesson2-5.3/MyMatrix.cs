using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_5._3
{
    class MyMatrix
    {
        int[] _array;
        public MyMatrix(params int[] array)
        {
            _array = array;
        }
        public void Column()
        {
            int[] newArray = new int[_array.Length + 1];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            newArray[_array.Length] = 3;
            Write(newArray);
        }
        public void Line(int num)
        {
            int[,] newArray = new int[_array.Length, num];
            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    newArray[i, j] = _array[i];
                    Console.Write($"{newArray[i, j]} ");
                }
            }
            Console.WriteLine();
        }
        public void Write(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
