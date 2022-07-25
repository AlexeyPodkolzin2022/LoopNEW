using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //нахождение квадратов чисел
            Console.Write("Введите натуральное число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Квадраты целых чисел от 1 до {0}:", n);
            for (int i = 1, sqr = 0; i <= n; i++)
                Console.WriteLine("{0}^2 = {1}", i, sqr += i * 2 - 1);
            Console.ReadKey();
        }
    }
}
