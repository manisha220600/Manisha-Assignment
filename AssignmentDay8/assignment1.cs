using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay8
{

    internal class assignment1
    {
        public static void Main()
        {
            List<int> list = new List<int>();
            for(int i = 0; i < 5; i++)
            {
                int n = int.Parse(Console.ReadLine());
                list.Add(n);

            }
            foreach(int n in list)
            {
                Console.Write(n+" ");
            }
            

        }
    }
}
