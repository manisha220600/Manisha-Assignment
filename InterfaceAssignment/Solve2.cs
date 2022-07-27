using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
 
        interface Playable
        {
            public int GetAmount();
            public void AddAmount(int x);
            public string Address();
        }
        internal class Solve2
        {
            public int cash;
            public string loc;
            public Solve2(int cash, string loc)
            {
                this.cash = cash;
                this.loc = loc;
            }
            public int GetAmount()
            {
                return cash;
            }
            public void AddAmount(int x)
            {
                cash += x;
            }
            public string Address()
            {
                return loc;
            }
            public static void Main()
            {
                Console.WriteLine("Enter Amount :");
                int am = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Address :");
                string? ad = Console.ReadLine();
                Solve2 obj = new Solve2(am, ad);
                int n;
                do
                {
                    Console.WriteLine("Press 1. Retrive Amount Due");
                    Console.WriteLine("Press 2. ADD To Amount Due");
                    Console.WriteLine("Press 3. Payment Address");
                    Console.WriteLine("Press 4. Exit");
                    n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Total Amount : {0}", obj.GetAmount());
                            break;
                        case 2:
                            Console.WriteLine("Amount To be Added");
                            int x = int.Parse(Console.ReadLine());
                            obj.AddAmount(x);
                            break;
                        case 3:
                            Console.WriteLine("Address : {0}", obj.Address());
                            break;
                    }

                } while (n != 4);
            }
        }
    }

