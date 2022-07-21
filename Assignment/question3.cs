using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class question3
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            while (n < b)
            {
                Console.WriteLine(n);
                n++;
            }
        }
    }
}
