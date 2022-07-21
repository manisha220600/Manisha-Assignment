using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class question10
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 5; i <= n; i++)
            {
                total = total + (i * i * i);
            }
            Console.WriteLine("Sum of the cubes of number from 5 to {0} is {1}",n,total);
        }
    }
}
