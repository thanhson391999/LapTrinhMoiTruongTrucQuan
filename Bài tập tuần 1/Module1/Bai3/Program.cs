using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nSo1, nSo2, nTong = 0;
            Console.Clear();
            Console.WriteLine("****Tong cua 2 so a va b*********");
            Console.Write("{0}", "Nhap so thu nhat: ");
            nSo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            nSo2 = Convert.ToInt32(Console.ReadLine());
            nTong = nSo1 + nSo2;
            Console.WriteLine("Tong cua " + nSo1 + " và " + nSo2 + " la " + nTong);
            Console.ReadLine();
        }
    }
}
