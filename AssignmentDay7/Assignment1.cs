using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AssignmentDay7
{
    internal class Assignment1
    {
        public static void Main()
        {
            int x;
            Console.WriteLine("Enter numbers: ");
            ArrayList arr = new ArrayList();
            for(int i = 0; i < 10; i++)
            {
                x = int.Parse(Console.ReadLine());
                arr.Add(x);
            }
            arr.Sort();
            Console.WriteLine("Numbers in ascedning order are: ");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
