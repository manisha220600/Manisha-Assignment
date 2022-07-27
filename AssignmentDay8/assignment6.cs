using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay8
{
    internal class assignment6
    {
        class Employee
        {
            public string EmpName;
            public string EmpDesig;
        }
        static void Main()
        {
            Dictionary<string, List<string>> ar = new Dictionary<string, List<string>>();
            Employee[] obj = new Employee[5];
            for (int i = 0; i < 5; i++)
            {
                obj[i] = new Employee();
                Console.WriteLine("Enter Name :");
                obj[i].EmpName = Console.ReadLine();
                Console.WriteLine("Enter Designation :");
                obj[i].EmpDesig = Console.ReadLine();
                if (!ar.ContainsKey(obj[i].EmpDesig))
                {
                    ar.Add(obj[i].EmpDesig, new List<string>());
                }
                ar[obj[i].EmpDesig].Add(obj[i].EmpName);
            }
            List<string> ls = new List<string>()
            {
                "Program Managers",
                "Project Manager",
                "Team Lead",
                "Senior Programmer",
                "Junior programmer"
                
            };
            foreach (var item in ls)
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
