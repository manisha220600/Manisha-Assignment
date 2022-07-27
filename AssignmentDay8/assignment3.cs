using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay8
{
    internal class assignment3
    {
        public static void Main()
        {
            int x;
            string str;
            Console.WriteLine("Enter Employee details:");
            SortedList<int,string> arr = new SortedList<int, string>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Employee Code: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee name: ");
                str = Console.ReadLine();
                arr.Add(x, str);
            }


            Console.WriteLine("Employee Deatils: ");
            foreach (var i in arr)
            {
                Console.WriteLine("Employee Code: {0} Employee Name: {1}", i.Key, i.Value);
            }


        }

    }
}
