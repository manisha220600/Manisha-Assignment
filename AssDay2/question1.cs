using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssDay2
{
    internal class question1
    {
        static void Main()
        {
            
            double p = 1000.00, An;
            int  i = 0;
            while (p < 100000)
            {
                An = p * .05;
                p += An;
                i++;
            }
            Console.WriteLine("Total number of yeras: "+i);
        }
    }
}
