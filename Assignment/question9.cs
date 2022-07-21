using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class question9
    {
        static void Main()
        {
            long a = 0, b = 1, c, i;
            Console.WriteLine("Fibonacci upto 40 :{0} ", a);
            Console.WriteLine("{0}", b);
            for(i = 0; i <39; i++)
            {
                c = a + b;
                a = b;
                b= c;
                Console.WriteLine("{0}", c);
            }
        }
    }
}
