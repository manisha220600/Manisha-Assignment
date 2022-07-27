using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay8
{
    class student
    {
        public int Id;
        public string Name;

        public student(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }

    internal class assignment5
    {
        
        
            public static void Main()
            {
                student[] st = new student[3];
                List<student> arr = new List<student>();
                for (int i = 0; i < st.Length; i++)
                {
                    st[i] = new student(i + 1, "Manisha" + i + 1);
                    arr.Add(st[i]);
                }
                foreach (student s in arr)
                {
                    Console.WriteLine("StudentId: {0} \t Student_Name: {1}", s.Id, s.Name);
                }


            }

        }
    }

