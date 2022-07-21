using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignmentAcc
{
    internal class Student
    {
        public int rollNo;
        public string name;
        public int classStd;
        public int sem;
        public string branch;
        public int[] marks = new int[5];

        public Student(int rollNo, string name, int classStd, int sem, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.classStd = classStd;
            this.sem = sem;
            this.branch = branch;
        }


        public string displayresult()
        {
            bool fail = false;
            int total = 0;
            for (int i = 0; i < this.marks.Length; i++)
            {
                total = total + this.marks[i];
                if(this.marks[i] < 35)
                {
                    fail = true;
                }
            }
            int average = total / this.marks.Length;
            if (fail)
            {
                return "failed";
            }
            else if(average < 50)
            {
                return "failed";
            }
            else
            {
                return "passed";
            }

            
        }
        public void display()
        {
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("Roll no.{0}: ",this.rollNo);
            Console.WriteLine("class:{0} ",this.classStd);
            Console.WriteLine("Sem:{0} ", this.sem);
            Console.WriteLine("branch:{0} ",this.branch);
            
        }

        static void Main()
        {
            
            Console.WriteLine("Enter your name: ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter your Roll no.: ");
            int rollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your standard: ");
            int classStd = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your semnumber: ");
            int sem = int.Parse(Console.ReadLine());    
            Console.WriteLine("Enter your branch: ");
            string branch = Console.ReadLine();
            Student st = new Student(rollNo,name,classStd,sem,branch);
            int[] marks = new int[5];
            Console.WriteLine("Enter marks of five subjects: ");
            for(int i=0;i< 5; i++)
            {
                marks[i] = int.Parse(Console.ReadLine()) ;

            }
            st.marks = marks;
            Console.WriteLine(st.displayresult());
            
            
            
            st.display();

        }
        

        
    }

}
