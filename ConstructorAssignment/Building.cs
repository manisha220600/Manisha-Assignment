using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class Building
    {
        public string type;
        public string Capacity;
        public string dimension;
        public string floor;
        public string dateofcompletion;

        Building()
        {
            Console.WriteLine("Enter type: ");
            type = Console.ReadLine();
            if(String.Compare(type,"flat",true) == 0)
            {
                Console.WriteLine("Enter Floor Number: ");
                floor = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enter Dimension: ");
                dimension = Console.ReadLine();
            }
            Console.WriteLine("Enter Capacity: ");
            Capacity = Console.ReadLine();
            Console.WriteLine("Enter date of completion ");
            dateofcompletion = Console.ReadLine();
        }
        public void showdata()
        {
            if (String.Compare(type, "flat", true) == 0)
            {
                Console.WriteLine($" Type: {type} Capacity: {Capacity} floor: {floor} Dateofcomplition: {dateofcompletion}");
            }
            else
            {
                Console.WriteLine($" Type: {type} Capacity: {Capacity} floor: {floor} Dimension:{dimension} Dateofcomplition: {dateofcompletion}");
            }
        }
        public static void Main()
        {
            Building obj=new Building();
            Console.WriteLine();
            obj.showdata();
        }


    }
}
