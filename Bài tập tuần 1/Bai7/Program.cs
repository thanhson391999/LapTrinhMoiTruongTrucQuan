using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Double fx;
            Console.WriteLine("******Cac ham luong giac********");
            Console.Write("Nhap vao 1 goc: ");
            fx = Convert.ToDouble(Console.ReadLine());
            Double rad = fx * Math.PI / 180;
            Console.WriteLine("Sin({0})= {1}", fx, Math.Sin(rad));
            Console.WriteLine("Cos({0})= {1}", fx, Math.Cos(rad));
            Console.WriteLine("Tan({0})= {1}", fx, Math.Tan(rad));
            Console.WriteLine("CogTan({0})= {1}", fx, Math.Cos(rad) / Math.Sin(rad));
            Console.ReadKey();
        }
    }
}
