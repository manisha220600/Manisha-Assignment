using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3
{
    internal class question2
    {
        static void Main()
        {
            int i,n=Convert.ToInt32(Console.ReadLine());
            string[] arr=new string[n];
            for (i = 0; i < n; i++)
            {
                string ?str=Console.ReadLine();
                arr[i] = str;
            }
            for(i=0;i<n;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
