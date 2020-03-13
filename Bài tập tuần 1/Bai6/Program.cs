using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            double nSo1, nSo2, nSo3, nX1, nX2, nX;
            Console.Write("{0}\n{1}", "*****Giai va bien luan PT bac 2*********", "Nhap vao so thu nhat: ");
            nSo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            nSo2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so thu ba: ");
            nSo3 = Convert.ToInt32(Console.ReadLine());
            if (nSo1 == 0)
            {
                if (nSo2 == 0)
                {
                    if (nSo3 == 0)
                    {
                        Console.WriteLine("PT vo so nghiem");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("PT vo nghiem");
                        Console.ReadLine();
                    }
                }
                else
                {
                    nX = -nSo3 / nSo2;
                    Console.WriteLine("PT co 1 nghiem X = " + nX);
                    Console.ReadLine();
                }
            }
            else
            {
                double nDelta = (nSo2 * nSo2) - 4 * nSo1 * nSo3;
                if (nDelta < 0)
                {
                    Console.WriteLine("PT vo nghiem");
                    Console.ReadLine();
                }
                else if (nDelta == 0)
                {
                    nX1 = -nSo2 / (2 * nSo1);
                    Console.WriteLine("PT co nghiem keo X1 = X2 = " + nX1);
                    Console.ReadLine();
                }
                else
                {
                    nX1 = (-nSo2 - Math.Sqrt(nDelta)) / (2 * nSo1);
                    nX2 = (-nSo2 + Math.Sqrt(nDelta)) / (2 * nSo1);
                    Console.WriteLine("{0}\n{1}\n{2}", "PT co 2 nghiem phan biet: ", "X1 = " + nX1, "X2 = " + nX2);
                    Console.ReadLine();
                }
            }
        }
    }
}
