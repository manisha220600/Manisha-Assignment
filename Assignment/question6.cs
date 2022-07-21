using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class question6
    {
        static void Main()
        {
            Console.WriteLine("Enter Temperature in Farenhite");
            int ?a=Convert.ToInt16(Console.ReadLine());
            float? b =(float) ((a - 32) * 5) / 9;
            Console.WriteLine("Temperature is Celsius: {0}", b);
        }
    }
}
