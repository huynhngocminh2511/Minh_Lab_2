using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            Console.WriteLine("ngay " + str[0] + str[1] + " thang " + str[3] + str[4] + " nam " + str[6] + str[7] + str[8] + str[9]);
            Console.WriteLine($"ngay {str[0]}{str[1]} thang {str[3]}{str[4]} nam {str[6]}{str[7]}{str[8]}{str[9]}");
            Console.WriteLine(String.Format("ngay {0}{1} thang {2}{3} nam {4}{5}{6}{7}", str[0], str[1], str[3], str[4], str[6], str[7], str[8], str[9]));
            var day = int.Parse(str[0].ToString() + str[1]);
            var month = int.Parse(str[3].ToString() + str[4]);
            var year = int.Parse(str[6].ToString() + str[7] + str[8] + str[9]);
            Console.WriteLine(new DateTime(year, month, day).ToString("'ngay' dd 'thang' MM 'nam' yyyy"));
            Console.ReadKey();
        }
    }
}
