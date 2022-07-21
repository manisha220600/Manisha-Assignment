using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class question5
    {
        static void Main()
        {
            int ?n=Convert.ToInt32(Console.ReadLine());
            int i = 0; int cnto = 0; int cnte = 0;
            for(i=0; i < n; i++)
            {
                int ?x=Convert.ToInt32(Console.ReadLine());
                if (x % 2 == 0)
                {
                    cnte++;
                }
                else
                {
                    cnto++;
                }

            }
            Console.WriteLine("Number of odd: {0} number of even:{1}", cnto, cnte);
        }
    }
}
