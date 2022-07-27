using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{

    interface IGovtRules
    {
        public double EmployeePF(double basicSalary);

        public string LeaveDetails();
        public double gratuityDetails(float serviceCompleted, double basicSalary);
    }

    class TCS : IGovtRules
    {
        public int empid;
        public string name;
        public string dept;
        public string desg;
        public double basic_salary;

        public TCS(int empid, string name, string dept, string desg, double basic_salary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basic_salary = basic_salary;
        }

        public double EmployeePF(double basicSalary)
        {
            double pf1 = (0.12 * basicSalary), pf2 = (0.833 * basicSalary), pf3 = (0.367 * basicSalary);

            return pf1 + pf2 + pf3;
        }
        public string LeaveDetails()
        {
            string str = @"1. 2Day of casual Leave per month.
                         2. 5 Days of Sick leave per year.
                         3. 3Days of Previlage Leave per year.";
            return str;
        }
        public double gratuityDetails(float serviceCompleted, double basicsalary)
        {
            
            if (serviceCompleted > 5)
            {
                return basicsalary;
            }
            else if (serviceCompleted > 10)
            {
                return 2 * basicsalary;
            }
            else if (serviceCompleted > 20)
            {
                return 3 * basicsalary;
            }
            else
            {
                return 0;
            }

        }
        public void Display()

        {
            Console.WriteLine("Enter Employee details: ");
            Console.WriteLine($" Employee_Id:{empid} \n Employee_Name:{name} \n Department: {dept} Designation:{desg} \n Basic_Salary:{basic_salary}");
        }
    }
    class Accenture : IGovtRules
    {
        public int empid;
        public string name;
        public string dept;
        public string desg;
        public double basic_salary;
    
            public Accenture(int empid, string name, string dept, string desg, double basic_salary)
            {
                this.empid = empid;
                this.name = name;
                this.dept = dept;
                this.desg = desg;
                this.basic_salary = basic_salary;
            }
        public double EmployeePF(double basicSalary)
        {
            double pf1 = (.12 * basicSalary), pf2 = (.12 * basicSalary);

            return pf1 + pf2;
        }
        public string LeaveDetails()
        {
            string str = @"1. 2Day of casual Leave per month.
                         2. 5 Days of Sick leave per year.
                         3. 3Days of Previlage Leave per year.";
            return str;
        }
        public double gratuityDetails(float serviceCompleted,double basicsalary)
        {
            return 0;
            
        }
            public void Display()

            {
                Console.WriteLine("Enter Employee details: ");
                Console.WriteLine($" Employee_Id:{empid} \n Employee_Name:{name} \n Department: {dept} Designation:{desg} \n Basic_Salary:{basic_salary}");
            }
        }
        internal class Solve
        {
            static void Main()
            {
            Random rd = new Random();
            int emid = rd.Next();
            Console.WriteLine("Enter Your Name");
            string nm=Console.ReadLine();
            Console.WriteLine("Enter Department: ");
            string dept=Console.ReadLine();
            Console.WriteLine("Enter Designation: ");
            string dg=Console.ReadLine();
            Console.WriteLine("Enter basic salary: ");
            int sal=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Company:");
            string comp=Console.ReadLine();
            Console.WriteLine("Enter year of experience: ");
            float n=float.Parse(Console.ReadLine());
            if (string.Compare(comp, "TCS", true )== 0)
            {
                TCS obj = new TCS(emid, nm, dept, dg, sal);
                obj.Display();
                Console.WriteLine(" PF : {0}", obj.EmployeePF(sal));
                Console.WriteLine("\t\t\t\t  Leave details");
                Console.WriteLine(obj.LeaveDetails());
                Console.WriteLine("Gratituty value: ", obj.gratuityDetails(n, sal));


            }
            else
            {
                TCS obj = new TCS(emid, nm, dept, dg, sal);
                obj.Display();
                Console.WriteLine(" PF : {0}", obj.EmployeePF(sal));
                Console.WriteLine("\t\t\t\t  Leave details");
                Console.WriteLine(obj.LeaveDetails());
                Console.WriteLine("Gratituty value: ", obj.gratuityDetails(n, sal));


            }





        }
     }
}
