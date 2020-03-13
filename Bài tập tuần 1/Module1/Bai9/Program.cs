using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x, n, S = 0;
            Console.WriteLine("{0}", "******Tinh tong chuoi so**********");
            Console.Write("Nhap x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            int z = 1;
            for (int i = 1; i <= n; i++)
                S = S + (Math.Pow(x, i) / (z = i * z));
            Console.Write("S(" + x + "," + n + ")= " + Math.Round(S, 3));
            Console.ReadLine();
        }
    }
}
