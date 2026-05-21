using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class newclass
    {
        int a;
        int b;
        public newclass(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void add()
        {
            int c = a + b;
            Console.WriteLine("sum is: "+c);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            newclass obj = new newclass(10, 20);
            obj.add();
            Console.ReadLine();
        }
    }
}
