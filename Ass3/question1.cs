using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3
{
    internal class question1
    {
        static void Main()
        {
            int i = 1;
            double bal, n,temp;
            Console.WriteLine("Enter Balance");
            bal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Monthly Payment");
            n= Convert.ToDouble(Console.ReadLine());
            while (bal > 0)
            {
                temp = bal * .015;
                bal = bal + temp - 100;
                bal=Math.Round(bal,3);
                Console.WriteLine("Monthly: {0} Balance: {1} Total Payments: {2}",i,bal,n);
                n += 100;
                i++;
            }
        }
    }
}
