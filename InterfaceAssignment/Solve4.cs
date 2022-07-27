using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    abstract class Abc
    {
        public int sales;
        public abstract int MSales(int amount);
        public int Sales()
        {
            return sales;
        }
    }
    interface Iyz
    {
        public int ASales(int amount);
    }
    class Solve4 : Abc, Iyz
    {
        public override int MSales(int amount)
        {
            return amount * 30;
        }
        public int ASales(int amount)
        {
            return amount * 30 * 12;
        }
        public static void Main()
        {
            Solve4 obj = new Solve4();
            Console.WriteLine("Enter Sales");
            obj.sales = int.Parse(Console.ReadLine());
            Console.WriteLine("Daily Sales : Rs {0}", obj.Sales());
            Console.WriteLine("Monthly Sales : Rs {0}", obj.MSales(obj.sales));
            Console.WriteLine("Annual Sales : Rs {0}", obj.ASales(obj.sales));
        }
    }
}
