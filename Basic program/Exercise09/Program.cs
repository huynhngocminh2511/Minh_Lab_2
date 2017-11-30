using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            var sum = q + w;
            var str = sum.ToString();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.ReadKey();
        }
    }
}
