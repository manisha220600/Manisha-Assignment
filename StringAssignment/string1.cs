using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class string1
    {
        public string str = "The quick brown fox jumps over the lazy dog";
        public char charindex()
        {
            return str[12];
        }
        bool chk(string s)
        {
            return str.Contains(s);

        }
        public string ad(string s)
        {
            string temp = string.Concat(str+" ", s);
            return temp;
        }
        public bool ch(string s)
        {
            return str.EndsWith(s);
        }
        public string c(string s)
        {
            return (String.Compare(str, s,true) == 0)?"Equal":"NotEqual";
        }
        public int len()
        {
            return str.Length;
        }
        public bool chh(string s)
        {
            return str == s;
        }
        public string rep(string s)
        {
            string temp= str.Replace("The",s);
            return temp;
        }
        public void splt()
        {
            String[] arr = str.Split('s');
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
        }
        public void spl()
        {
            String[] arr = str.Split('s');
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
        }
        public void separate()
        {
            Console.WriteLine("Print Animal Names: ");
            String[] arr = str.Split(" ");
            foreach (string s in arr)
            {
                if(s=="dog" || s == "fox")
                {
                    Console.Write(s+" ");
                }
            }
            Console.WriteLine();
        }
        public string asitis(String s)
        {
            return s;
        }
        public void verb(string s)
        {
            string addpath = @"/webApps/MyApps/Images";
            Console.WriteLine("Updates path is: "+s+addpath);
        }

        static void Main()
        {
            string1 obj=new string1();
            Console.WriteLine(obj.charindex());
            Console.WriteLine(obj.chk("is"));
            Console.WriteLine(obj.ad("and killed at"));
            Console.WriteLine(obj.ch("dogs"));
            Console.WriteLine(obj.c("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG"));
            Console.WriteLine(obj.len());
            Console.WriteLine(obj.chh("The quick brown fox jumps over the lazy dog"));
            Console.WriteLine(obj.rep("A"));
            obj.spl();
            obj.separate();
            Console.WriteLine("In lower format: " + obj.str.ToLower());
            Console.WriteLine("In upper format: "+ obj.str.ToUpper());
            Console.WriteLine(obj.str.IndexOf('a'));
            Console.WriteLine(obj.str.LastIndexOf('e'));
            Console.WriteLine("Enter a path");
            string path=Console.ReadLine();
            obj.verb(path);
            string s = @"I WANDER'D lonely as a cloud
That floats on high o'er vales and hills, 
When all at once I saw a crowd,
A host, of golden daffodils;Beside the lake, beneath the trees,
Fluttering and dancing in the breeze.";
            Console.WriteLine(obj.asitis(s));

        }
        
    }
}
