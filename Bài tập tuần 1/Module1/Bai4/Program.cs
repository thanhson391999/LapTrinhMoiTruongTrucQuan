using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nSo1, nSo2, nCV, nDT;
            Console.WriteLine("****Tinh chu vi va dien tich*********");
            Console.Write("{0}", "Nhap so thu nhat: ");
            nSo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            nSo2 = Convert.ToInt32(Console.ReadLine());
            nCV = (nSo1 + nSo2) * 2;
            nDT = nSo1 * nSo2;
            Console.WriteLine("Chu vi = " + nCV);
            Console.WriteLine("Dien tich = " + nDT);
            Console.ReadLine();
        }
    }
}
