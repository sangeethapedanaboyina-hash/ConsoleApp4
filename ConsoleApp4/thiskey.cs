using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class thisstudent
    {
        int stdid;
        string stdname;
        public thisstudent(int stdid, string stdname)
        {
            this.stdid = stdid;
            this.stdname = stdname;
        }
        public void display()
        {
            Console.WriteLine("student id is: " + stdid);
            Console.WriteLine("student name is: " + stdname);

        }
    }
    internal class thiskey
    {
        //static void Main(string[]args)
        //{
        //    thisstudent obj = new thisstudent(1, "sangeetha");
        //    obj.display();
    
        
    }
}
