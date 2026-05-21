using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class enduser
    {
        int stdid;
        string stdname;
        public enduser(int stdid, string stdname)
        {
            this.stdid = stdid;
            this.stdname = stdname;
        }
        public void display()
        {
            Console.WriteLine("student id is: " + stdid);
            Console.WriteLine("student name is: " + stdname);
            Console.WriteLine("============================");
        }
    }

    internal class userinput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of elements");
            int n = int.Parse(Console.ReadLine());
            enduser [] students = new enduser[n];
                for(int i=0;i<n;i++)
            {
                Console.WriteLine("enter student id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter student name:");
                string name = Console.ReadLine();
                students[i] = new enduser(id,name);
            }
             Console.WriteLine("student details are: ");
            for (int i = 0; i < students.Length; i++)
            {
                students[i].display();
            }
        }


    }
}
