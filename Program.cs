using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovik
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, N;
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("N = ");
            N = Convert.ToDouble(Console.ReadLine());
          
            double h, sum1 = 0, sum2 = 0, sum = 0;
            h = (b - a) / (2 * N);
            for (int i = 1; i <= 2 * N - 1; i += 2)
            {           
                sum2 += f(a + h * i);
            }
            sum2 *= 4;
            for (int i = 2; i <= 2 * N - 2; i += 2)
            {              
                // Значения с чётными индексами, которые нужно умножить на 2.
                sum1 += f(a + h * (i + 1));
            }
            sum1 *= 2;
            sum = (b - a) / (6 * N) * (f(a) + sum2 + sum1);
            Console.Write("Ответ:" + sum);
            Console.ReadKey();
        }

        static double f(double x)
        {
            return x * x * Math.Sqrt(4 - x * x);
        }

    }
}

