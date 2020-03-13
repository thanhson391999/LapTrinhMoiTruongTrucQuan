using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            double nSo1, nSo2, nSo3, nCV, nP, nDT;
            do
            {
                Console.Write("{0}\n{1}", "*****Xet 3 so a b c co tao thanh tam giac va tinh CV , DT*********", "Nhap vao so thu nhat: ");
                nSo1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap vao so thu hai: ");
                nSo2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap vao so thu ba: ");
                nSo3 = Convert.ToInt32(Console.ReadLine());
                if ((nSo1 * nSo1 + nSo2 * nSo2 > nSo3 * nSo3 && nSo1 * nSo1 + nSo3 * nSo3 > nSo2 * nSo2 && nSo2 * nSo2 + nSo3 * nSo3 > nSo1 * nSo1) && (nSo1 > 0 && nSo2 > 0 && nSo3 > 0))
                {
                    Console.WriteLine("Day la mot tam giac");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Day khong phai la mot tam giac");
                    Console.Write("Hay thu so khac nhe !");
                    Console.ReadLine();
                }
            } while ((nSo1 <= 0 || nSo2 <= 0 || nSo3 <= 0) || (nSo1 * nSo1 + nSo2 * nSo2 < nSo3 * nSo3 || nSo1 * nSo1 + nSo3 * nSo3 < nSo2 * nSo2 || nSo2 * nSo2 + nSo3 * nSo3 < nSo1 * nSo1));
            nCV = nSo1 + nSo2 + nSo3;
            Console.WriteLine("Chu Vi Tam Giac: " + nCV);
            nP = nCV / 2;
            nDT = Math.Sqrt(nP * (nP - nSo1) * (nP - nSo2) * (nP - nSo3));
            Console.WriteLine("Dien Tich Tam Giac: " + nDT);
            Console.ReadLine();
        }
    }
}
