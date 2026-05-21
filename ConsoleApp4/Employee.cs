using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class emp
    {
        int empid;
        string empname;
        double empsal;
        public emp(int empid, string empname,double empsal)
        {
            this.empid = empid;
            this.empname = empname;
            this.empsal = empsal;

        }
        public void display()
        {
            Console.WriteLine("Employee id is: " + empid);
            Console.WriteLine("Employee name is: " + empname);
            Console.WriteLine("Employee Salary is: " + empsal);
            Console.WriteLine("=================================");
        }
    }
    internal class Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  number of Employee ");
            int n=int.Parse(Console.ReadLine());
            emp[] employee=new emp[n]; 
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter Employee id:");
                int eid = int.Parse(Console.ReadLine());
                Console.WriteLine("enter Employee name:");
                string ename=Console.ReadLine();
                Console.WriteLine("enter Employee salary:");
                double esal=double.Parse(Console.ReadLine());
                employee [i]=new emp(eid,ename,esal);
            }
            Console.WriteLine("employee details are:");
            for (int i = 0; i < employee.Length; i++)
            {
              
               employee[i].display();

            }

        }
    }
}
