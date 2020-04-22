using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mlily.WMSInterface.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = Encoding.Unicode;
            System.Console.WriteLine("=====Mlily.WMSInterface.Console Scans data.=====");

            SystemJobManager.Instance.Start();

            System.Console.ReadLine();
        }
    }
}
