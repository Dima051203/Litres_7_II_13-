using System;

namespace Litres_7_II_13_Поменять_местами_первый_минимальный_и_последний_максимальный_элементы_
{
    class Program
    {
        static void Print(int[] a)
        {
            foreach(int elem in a)
            {
                Console.Write("{0} ", elem);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] a = { 1, -5, -1, 4, 5, 4, 7, 9, 3, 2, 6, };
            int max = a[0];
            int indexOfMax = 0;
            for(int i = 1; i < a.Length; i++)
            {
                if(a[i] > max)
                {
                    max = a[i];
                    indexOfMax = i;
                }
            }
            Console.WriteLine("Исходный массив: ");
            Print(a);
            Console.WriteLine("Максимальный элемент {0} с индексом {1} ", max, indexOfMax);
            int min = a[0];
            int indexOfMin = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    indexOfMin = i;
                }
            }
            Console.WriteLine("Минимальный элемент {0} с индексом {1} ", min, indexOfMin);
            int c = a[indexOfMax];
            a[indexOfMax] = a[indexOfMin];
            a[indexOfMin] = c;
            Console.WriteLine("Изменённый массив: ");
            Print(a);
        }
    }
}
