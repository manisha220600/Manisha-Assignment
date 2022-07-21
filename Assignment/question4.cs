using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class question4
    {
        static void Main()
        {
            int  ? a = Convert.ToInt32(Console.ReadLine());
            
            if (a % 2 == 0)
            {
                Console.WriteLine("{0} is even number",a);
            }
            else
            {
                Console.WriteLine("{0} is odd number", a);
            }
        }
    }
}
