using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class question8
    {
         static void Main()

        {
            int i,n = Convert.ToInt32(Console.ReadLine());
            long ll = 1;
            for(i = 1; i <= n; i++)
            {
                ll *= i;
            }
            Console.WriteLine("factorial for {0}: {1}",n,ll);
        }
    }
}
