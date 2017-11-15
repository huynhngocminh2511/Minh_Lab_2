using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07_08
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write("Exercise7: ");
            if (n == 1 || n == 2)
            {
                Console.WriteLine(1);
            }
            var q = 1;
            var w = 1;
            var e = 2;
            for (int i = 3; i <= n; i++)
            {
                e = q + w;
                q = w;
                w = e;
            }
            Console.WriteLine(e);
            Console.Write("Exercise8: ");
            var sum = 0;
            for (int i = 2; i <= n; i++)
            {
                if (check(i))
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        static bool check(int q)
        {
            for (int i = 2; i <= (int)Math.Sqrt(q); i++)
            {
                if (q % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
