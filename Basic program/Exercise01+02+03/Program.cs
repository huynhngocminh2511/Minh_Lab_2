using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.Read();
            n = n - '0';
            if (n == 1)
            {
                Console.WriteLine("Sunday");
            } else
            if (n == 2)
            {
                Console.WriteLine("Monday");
            } else
            if (n == 3)
            {
                Console.WriteLine("Tuesday");
            } else
            if (n == 4)
            {
                Console.WriteLine("Wednesday");
            } else
            if (n == 5)
            {
                Console.WriteLine("Thursday");
            } else
            if (n == 6)
            {
                Console.WriteLine("Friday");
            } else
            if (n == 7)
            {
                Console.WriteLine("Saturday");
            } else
            {
                Console.WriteLine("Invalid day");
            }
            switch (n)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
            string[] a = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            if (1<=n&& n <= 7)
            {
                Console.WriteLine(a[n - 1]);
            } else
            {
                Console.WriteLine("Invalid day");
            }
            Console.ReadKey();
        }
    }
}
