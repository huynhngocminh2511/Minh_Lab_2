using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            str = str.Trim();
            str = str.ToLower();
            var nstr = "";
            for (int i = 0; i <= str.Length - 1; i++) 
            {
                if (i != 0 && str[i - 1] == ' ' && str[i] == ' ')
                {
                    continue;
                }
                if (i == 0 || str[i - 1] == ' ')
                {
                    nstr = nstr + (char)((int)str[i] + 'A' - 'a');
                } else
                {
                    nstr = nstr + str[i];
                }
            }
            Console.WriteLine(nstr);
            Console.ReadKey();
        }
    }
}
