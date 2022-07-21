using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class question14
    {
        static void Main()
        {
            int[] a = new int[5];

            Console.WriteLine("Enter 5 Elements in array: ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int minval = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
                //nsole.WriteLine();

                if (minval > a[i])
                {
                    minval = a[i];

                }
            }
            Console.WriteLine();
        Console.WriteLine("the smallest number is {0} ", minval);
        }   }
    }


