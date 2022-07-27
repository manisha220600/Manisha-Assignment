using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AssignmentDay7
{
    class Employee
    {
        public string EmpName;
        public string EmpDesig;
        //public Employee(string empName, string empDesig)
        //{
        //    EmpName = empName;
        //    EmpDesig = empDesig;
        //}
    }
    internal class Assignment6
    {
        public static void Main()
        {
            Dictionary<string, List<string>> ar = new Dictionary<string, List<string>>();
            Employee[] obj = new Employee[3];
            for (int i = 0; i < 3; i++)
            {
                obj[i] = new Employee();
                Console.WriteLine("Enter Name :");
                obj[i].EmpName = Console.ReadLine();
                Console.WriteLine("Enter Designamtion :");
                obj[i].EmpDesig = Console.ReadLine();
                if (!ar.ContainsKey(obj[i].EmpDesig))
                {
                    ar.Add(obj[i].EmpDesig, new List<string>());
                }
                ar[obj[i].EmpDesig].Add(obj[i].EmpName);
            }
            foreach (var item in ar.Keys)
            {
                Console.Write(item + " : ");
                foreach (var x in ar[item])
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
        }
    }
}