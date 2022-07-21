using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class question15
    {
        static void Main()
        {
            Console.WriteLine("Enter randome 10 marks of students: ");
            int[] marks = new int[10];
            int total = 0;
            float average = 0.0F; ;
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
                total = total + marks[i];

            }
            average = total / 10;
            int maxval = marks[0];
            int minval = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (maxval < marks[i])
                {
                    maxval = marks[i];
                }
                if (minval > marks[i])
                {
                    minval = marks[i];
                }
            }
            Console.WriteLine("Total sum: {0} ", total);
            Console.WriteLine("total average:{0}", average);
            Console.WriteLine("Maxmimum marks:{0}", maxval);
            Console.WriteLine("minimum marks:{0}", minval);
            Array.Sort(marks);
            Console.WriteLine();
            Console.WriteLine("Ascending order: ");
            for(int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] +" ");
            }
            Console.WriteLine();
            Console.WriteLine("Descending order: ");
            Array.Reverse(marks);
            for(int j = 0; j < marks.Length; j++)
            {
                Console.Write(marks[j] + " ");
            }

        }
    }
}
