using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13_14_15_16_17_18
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write("Exercise13: ");
            var sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + Math.Pow(i, i);
            }
            Console.WriteLine(sum);
            Console.Write("Exercise14: ");
            sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + (i * (i + 1));
            }
            Console.WriteLine(sum);
            Console.Write("Exercise15: ");
            sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + (1.0 / (i * (i + 1)));
            }
            Console.WriteLine(sum);
            Console.Write("Exercise16: ");
            double[] a = new double[n + 2];
            a[0] = 1;
            for (int i = 1; i <= n+1; i++)
            {
                a[i] = a[i - 1] * i;
            }
            sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + (a[i] / (i * (i + 1)));
            }
            Console.WriteLine(sum);
            Console.Write("Exercise17: ");
            sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + (1 / (a[i] * a[i + 1]));
            }
            Console.WriteLine(sum);
            Console.WriteLine("Exercise18: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    var t = a[i] / (a[j] * a[i - j]);
                    Console.Write(t + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
