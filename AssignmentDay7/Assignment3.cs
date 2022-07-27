using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace AssignmentDay7
{
    internal class Assignment3
    {
        public static void Main()
        {
            int x;
            string str;
            Console.WriteLine("Enter Emplouee details: ");
            SortedList arr = new SortedList();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Employee Code: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee name: ");
                str = Console.ReadLine();
                arr.Add(x,str);
            }
            
            
            Console.WriteLine("Employee Deatils: ");
            foreach (DictionaryEntry i in arr)
            {
                Console.WriteLine("Employee Code: {0} Employee Name: {1}", i.Key, i.Value);
            }


        }
    }
}
