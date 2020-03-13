using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Listener
    {
        public void GetNotified(string sInfo)
        {
            Console.WriteLine("I got Notified with the following information {0}", sInfo);
            Console.ReadLine();
        }
        public static void GetNotifiedAgain(string sInfo)
        {
            Console.WriteLine("I got Notified with the following information {0}", sInfo);
            Console.ReadLine();
        }
    }
}
