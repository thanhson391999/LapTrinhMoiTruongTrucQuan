using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            float nSo1, nSo2, nX;
            Console.WriteLine("****Giai va bien luan pt bac 1*********");
            Console.Write("{0}", "Nhap so thu nhat: ");
            nSo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            nSo2 = Convert.ToInt32(Console.ReadLine());
            if (nSo1 == 0)
            {
                if (nSo2 == 0)
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
                nX = -nSo2 / nSo1;
                Console.WriteLine("PT co 1 nghiem X = " + nX);
                Console.ReadLine();
            }
        }
    }
}
