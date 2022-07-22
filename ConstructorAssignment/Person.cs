using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    internal class Person
    {
        public string Frist_Name;
        public string Last_Name;
        public DateTime Dob;
        public string Email;

        public Person()
        {
            Accept();

        }

        public Person(string frist_Name, string last_Name, DateTime dob, string email)
        {
            Frist_Name = frist_Name;
            Last_Name = last_Name;
            Dob = dob;
            Email = email;
        }
        
        public Person(string frist_Name, string last_Name, string email)
        {
            Frist_Name = frist_Name;
            Last_Name = last_Name;
            Email = email;

        }
        public Person(string frist_Name, string last_Name, DateTime dob)
        {
            Frist_Name = frist_Name;
            Last_Name = last_Name;
            Dob = dob;

        }

        public void Accept()
        {
            Console.WriteLine("Enter your First Name: ");
            Frist_Name = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            Last_Name = Console.ReadLine();
            Console.WriteLine("Enter your date of birth: ");
            Dob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter your email: ");
            Email = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine($"First_name: {Frist_Name} Last_name: {Last_Name} Date_Of_Birth: {Dob} Email: {Email}");
        }
        public static void Main()
        {
            Person obj1 = new Person();
            obj1.Display();
            Person obj= new Person(obj1.Frist_Name, obj1.Last_Name, obj1.Email);
            obj.Display();
            Person obj2 = new Person(obj1.Frist_Name, obj1.Last_Name, obj1.Dob);
            obj2.Display();

        }
    } 
}
