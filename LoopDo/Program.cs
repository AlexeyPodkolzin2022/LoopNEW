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
            //Сравнение количества положительных и отрицательных целых чисел
            int n;
            int a = 0;
            int b = 0;
            do
            {
                Console.WriteLine("Введите число:");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                    a++;
                else b++;
            }
            while (n != 0);
            int c = a - b;
            if (c > 0)
                Console.WriteLine("Положительных чисел больше");
            else
                Console.WriteLine("Отрицательных чисел больше");
            Console.ReadKey();
        }
    }
}
