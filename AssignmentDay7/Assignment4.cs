using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AssignmentDay7
{
    class BookStore
    {
        public int bkid;
        public string bname;

        public BookStore(int bkid, string bname)
        {
            this.bkid = bkid;
            this.bname = bname;
        }
    }

    internal class Assignment4
    {
        public static void Main()
        {
            Hashtable hs = new Hashtable();

            BookStore obj = new BookStore(123, "harry potter 1");
            hs.Add(obj.bkid, obj.bname);
            BookStore obj2 = new BookStore(1234, "harry potter2 ");
            hs.Add(obj2.bkid, obj2.bname);
            BookStore obj3 = new BookStore(1235, "harry potter3");
            hs.Add(obj3.bkid, obj3.bname);

            foreach(var i in hs.Keys)
            {
                Console.WriteLine("Book_Id: {0} \t Book_Name: {1}",i,hs[i]);
            }
        }
    }
}
