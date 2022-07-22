using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class shape
    {
        public int length;
        public int breadth;
        public double len;
        public double bd;
        public int area(int a, int b)// rect
        {
            return a * b;
        }
        public double area(double a,double b)//tri
        {
            return 0.5 * a * b;
        }
        public int area(int a)// square
        {
            return a * a;
        }
        public double area(double a)// circle
        {
            return 3.14 * a * a;
        }
        public static void Main()
        {
            shape shape1 = new shape();
            Console.WriteLine("Enter Length For Rectangle");
            shape1.length=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth for Rectangle");
            shape1.breadth=int.Parse(Console.ReadLine());
            Console.WriteLine("Area of rectangle is: {0}",shape1.area(shape1.length,shape1.breadth));


            Console.WriteLine("Enter radius for Circle");
            shape1.len=int.Parse(Console.ReadLine());
            Console.WriteLine("Area of circle is: {0}",shape1.area(shape1.len));


            Console.WriteLine("Enter height for Triangle");
            shape1.len=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width for triangle");
            shape1.bd = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of circle is: {0}", shape1.area(shape1.len,shape1.bd));


            Console.WriteLine("Enter length for Square");
            shape1.length = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of square is: {0}", shape1.area(shape1.length));
        }
    }
}
