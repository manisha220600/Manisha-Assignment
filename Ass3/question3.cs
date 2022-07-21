using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3
{
    internal class question3
    {
        static void Main()
        {
            string? str = Console.ReadLine();
            string[] arr = str.Split(" ", str.Length);
            Dictionary<string, int> dict = new Dictionary<string, int>(); 
            for(int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i])) dict[arr[i]]++;
                else dict[arr[i]] = 1;
                
            }
            foreach(KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine("{0}: {1}",kvp.Key,kvp.Value);  
            }
        }
    }
}
