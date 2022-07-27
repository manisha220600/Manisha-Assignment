using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AssignmentDay7
{
    internal class Assignment2
    {
        public static void Main()
        {
            string x;
            Console.WriteLine("Enter string: ");
            ArrayList arr = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                x = Console.ReadLine();
                arr.Add(x);
            }
            arr.Sort();
            arr.Reverse();
            Console.WriteLine("strings in descedning order are: ");
            foreach (string i in arr)
            {
                Console.WriteLine(i);
            }

        }
    }
}
