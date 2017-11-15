using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            var e = int.Parse(Console.ReadLine());
            Console.Write("Type: ");
            if (q + w > e && w + e > q && e + q > w)
            {
                int kt = 0;
                if (q == w && w == e)
                {
                    Console.WriteLine("Equilateral Triangle");
                    kt = 1; 
                } else
                {
                    if (q == w || w == e || e == q)
                    {
                        Console.WriteLine("Isosceles Triangle");
                        kt = 1;
                    }
                    if (q * q + w * w == e * e || w * w + e * e == q * q || e * e + q * q == w * w)
                    {
                        Console.WriteLine("Square Triangle");
                        kt = 1;
                    }
                }
                if (kt == 0)
                {
                    Console.WriteLine("Normal Triangle");
                }
                var perimeter = q + w + e;
                Console.WriteLine("Perimeter: " + perimeter);
                var area = Math.Sqrt((q + w + e) * (q + w - e) * (w + e - q) * (e + q - w))/4;
                Console.WriteLine("Area: " + area);
            } else
            {
                Console.WriteLine("Not Triangle");
            }
            Console.ReadKey();
        }
    }
}
