using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5
{
    internal class BookStore
    {
        public int Book_Number;
        private  string Book_Title;
        private  string Book_Name;
        private  string Book_Author;
        public int Quantity_Of_Books;
        private  int Book_Price;

        public void Update(int n)
        {
            Book_Number = n;
            Console.WriteLine("Alloted Book Number:{0} \n ",n);
            Console.WriteLine("Enter Book Tile:");
            Book_Title = Console.ReadLine();
            Console.WriteLine("Enter Book Name: ");
            Book_Name = Console.ReadLine();
            Console.WriteLine("Enter Book Author Name");
            Book_Author = Console.ReadLine();
            Console.WriteLine("Enter Quantity of Books:");
            Quantity_Of_Books = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Book Price");
            Book_Price = int.Parse(Console.ReadLine());

        }

        public bool check1(int n, string BookT,string  Bookname,string  BookA, int Quant)
        {
            if(n==Book_Number && BookT==Book_Title &&  Bookname==Book_Name && BookA==Book_Author )
            {
                if(Quant > Quantity_Of_Books)
                {
                    Console.WriteLine("Out of stock:(((");
                    return false;
                }
                else
                {
                    Quantity_Of_Books -= Quantity_Of_Books;
                         return true;
                }
            }
            Console.WriteLine("Sorry its unavailable right now... ");
            return false;
        }

       public void ad(int n, string BookT,string  Bookname,string  BookA, int Quant,int pr)
        {
            Book_Number = n;;
            Book_Title = BookT;
            Book_Name = Bookname;
            Book_Author = BookA;
            Quantity_Of_Books=Quant;
            Book_Price=pr;

        }
        public void Show()
        {
            Console.Write("Book Number: {0}",Book_Number);
            Console.Write("Book Name: {0}",Book_Name);
            Console.Write("Book Title: {0}",Book_Title);
            Console.Write("Book Author: {0}",Book_Author);
            Console.Write("Quantity of books: {0}",Quantity_Of_Books);
            Console.Write("Book Price: {0}",Book_Price);
            Console.WriteLine();
        }

        static void Main()
        {
            BookStore[] bookStore1 = new BookStore[100];
            BookStore[] purchase = new BookStore[10];
            int n,num=0,v=0,tsm=0;
            do
            {
                Console.WriteLine("Enter your Choice: ");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2.Customer");
                Console.WriteLine("3.Exit ");
                n = int.Parse(Console.ReadLine());

                if (bookStore1[num]==null) bookStore1[num]=new BookStore();

                int x;

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Welcome To Admin Portal \n");
                        
                        bookStore1[num].Update(num);
                        num++;
                        break;
                    case 2:
                        Console.WriteLine("Welcome to Jungle BookStore \n");
                        Console.WriteLine("-------------Jungle BookStore---------");
                        for(int i = 0; i < num; i++)
                        {
                            Console.WriteLine($"Book_Number: {bookStore1[i].Book_Number} Book_Name: {bookStore1[i].Book_Name} Book_Title: {bookStore1[i].Book_Title} Book_Author: {bookStore1[i].Book_Author} Price: {bookStore1[i].Book_Price}");

                        }
                        
                        do
                        {
                            Console.Write("Enter Book Number: ");
                            int bn = int.Parse(Console.ReadLine());
                            Console.Write("Enter Book Name:");
                            string BT = Console.ReadLine();
                            Console.Write("Enter Book Title: ");
                            string Bname = Console.ReadLine();
                            Console.Write("Enter Book Author Name");
                            string BA = Console.ReadLine();
                            Console.Write("Enter Quantity of Books:");
                            int Qnt = int.Parse(Console.ReadLine());

                            if (bookStore1[bn].check1(bn, BT, Bname, BA, Qnt))
                            {
                                purchase[v] = new BookStore();
                                purchase[v].ad(bn, BT, Bname, BA, Qnt, bookStore1[bn].Book_Price);
                                v++;
                                tsm += (Qnt * bookStore1[bn].Book_Price);
                            }
                            Console.WriteLine("Enter your choice 1 : Customer \n 0: Deline" );
                            x = int.Parse(Console.ReadLine());

                        } while (x != 0);
                        Console.WriteLine("-----------Purchase Details-----------");
                        for(int i = 0; i < v; i++)
                        {
                            purchase[i].Show();
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;

                }
            } while (n != 3);
         }

     }
}
