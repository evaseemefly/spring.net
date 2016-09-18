using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyselfIoC
{
    class Program
    {
        static void Main(string[] args)
        {
            AppRegistry();
            Console.ReadLine();
        }

        static void AppRegistry()
        {
            MyXmlFactory ctx = new MyXmlFactory(@"D:\Objects.xml");
            Console.WriteLine(ctx.GetObject("PersonDao").ToString());
        }
    }
}
