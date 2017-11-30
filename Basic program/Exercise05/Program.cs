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
            var n = int.Parse(Console.ReadLine());
            int[] a = new int[n + 2];
            for (int i = 1; i <= n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            sort(a, n);
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }
        static void sort(int[] a, int n)
        {
            for (int i = 1; i <= n - 1; i++) 
            {
                for (int j = i + 1; j <= n; j++) 
                {
                    if (a[i] > a[j]) 
                    {
                        swap(ref a[i], ref a[j]);
                    }
                }
            }
        }
        static void swap(ref int q,ref int w)
        {
            var t = q;
            q = w;
            w = t;
        }
    }
}
