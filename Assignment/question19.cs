using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class question19
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string res = string.Join(" ", s.Split(' ').Select(s => new String(s.Reverse().ToArray())));
            //Console.WriteLine(res);
            if (res == s)
            {
                Console.WriteLine("pallindrome");
            }
            else
            {
                Console.WriteLine("not a pallindrime");
            }
        }
    }
}