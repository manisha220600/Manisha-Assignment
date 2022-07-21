using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3
{
    internal class question4
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of Numbers: {0}", sum(n, b));
            int[] ar = new int[n];

        }
        public static int sum(int n, int b)
        {
            return n + b;
        }
    }
}
