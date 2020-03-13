using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Base.Method1");
            Console.ReadLine();
        }
        public override void Method1()
        {
            Console.WriteLine("in derived Method1");
            Console.ReadLine();
        }
        public Derived(string var)
        {
            Console.WriteLine("In Derived constructor.Constructor parameter value:{0}", var);
            Console.ReadLine();
        }
        public new void Method2()
        {
            Console.WriteLine("In Derived.Method2");
            Console.ReadLine();
        }
    }
}
