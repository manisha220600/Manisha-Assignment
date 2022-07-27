using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay8
{
    internal class assignment2
    {
        public static void Main()
        {
            List<string> list = new List<string>();
            string str;
            for(int i = 0; i < 5; i++)
            {
                str=Console.ReadLine();
                list.Add(str);

            }
            list.Sort();
            list.Reverse();
            foreach(string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
