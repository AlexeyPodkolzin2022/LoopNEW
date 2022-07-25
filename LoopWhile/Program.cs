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
            //Сколько квадратов со стороной С в прямоугольнике AB
            Console.Write("Введите A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int n = 0;
            while (a >= c)
            {
                a -= c;
                k++;
            }
            while (b >= c)
            {
                b -= c;
                n++;
            }
            int h = 0;
            int i = 0;
            while (i < k)
            {
                h += n;
                i++;
            }
            Console.WriteLine("Количество квадратов со стороной С = " + h);
            Console.ReadKey();
        }
    }
}
