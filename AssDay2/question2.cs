using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssDay2
{
    internal class question2
    {
        static void Main()
        {
            int[,] arr = new int[3, 3];
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j=0;j< arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
