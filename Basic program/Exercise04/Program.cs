using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            Console.WriteLine(ucln(q, w));
            Console.ReadKey();
        }
        static int ucln(int q, int w)
        {
            while (q * w != 0)
            {
                if (q>w)
                {
                    q = q % w;
                } else
                {
                    w = w % q;
                }
            }
            return q + w;
        }
    }
}
