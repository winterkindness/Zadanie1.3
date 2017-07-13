using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3
{
    class Pr3
    {
        static void Main(string[] args)
        {
            int n, i,max;
            Console.Write("Введите количество элементов массива: ");
            n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            Console.WriteLine("Введите элементы массива:");
            for (i = 0; i < n; i++)
            {
                Console.Write("Элемент " + (i + 1) + ": ");
                x[i] = int.Parse(Console.ReadLine());
            }
            max = x[0];            
            Console.WriteLine("Массив после обработки:");
            for (i = 0; i < n; i++)
                if (x[i] >= max)
                {
                    max = x[i];
                    Console.WriteLine(x[i]+" ");
                }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
