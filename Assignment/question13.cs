using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class question13
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Greatest is {0}", a);
                }
                else
                {
                    Console.WriteLine("Greatest is {0}", c);
                }
            }
            else if (b > c)
            {
                if (b > a)
                {
                    Console.WriteLine("Greatest is {0}", b);
                }
                else
                {
                    Console.WriteLine("Greatest is {0}", a);
                }
            }
            else
            {
                Console.WriteLine(c);
            }

        }
    }
}
