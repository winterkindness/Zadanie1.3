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
            int n, i;
            Console.Write("Введите количество элементов массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];
            Console.WriteLine("Введите элементы массива:");
            for (i = 0; i < n; i++)
                x[i] = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
                if (x[i] < x[i - 1])
                {
                    x[i] = x[i + 1];
                    n--;
                    i--;
                }
            Console.WriteLine("Массив после обработки:");
            for (i = 0; i < n; i++)
                Console.WriteLine("{0} ", x[i]);
            Console.ReadKey();
        }
    }
}
