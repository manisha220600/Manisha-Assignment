using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class question11
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(n + "x" + i + "=" + n * i);
            }
        }
    }
}
