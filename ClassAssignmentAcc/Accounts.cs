using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignmentAcc
{
    internal class Accounts
    {
        public int Account_No; // variable,data member,feilds,proeprties 
        public String Account_Name;
        public String Account_Type;
        public int amount, balance;
        public  char Transaction_type;
        public void credit(int amt)
        {
            this.balance+= amt;
        }
        public void debit(int amt)
        {
            this.balance-= amt;
        }
        public void accept(int accno,string name,string acctp)
        {
            Account_No = accno;
            Account_Name = name;
            Account_Type = acctp;
        }
        public void display()
        {
            Console.WriteLine("Account_Name:{0}",Account_Name);
            Console.WriteLine("Balance:{0}",balance);
            Console.WriteLine("Account_no:{0}",Account_No);
            Console.WriteLine("Account_Type:{0}", Account_Type);
        }
        static void Main()
        {
            Accounts accounts = new Accounts();
            Console.WriteLine("Enter your Name: ");
            accounts.Account_Name = Console.ReadLine();
            Console.WriteLine("Enter your acc no: ");
            accounts.Account_No = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter acc type: ");
            accounts.Account_Type = Console.ReadLine();
            Console.WriteLine("Enter your balance: ");
            accounts.balance=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your transcation type");
            accounts.Transaction_type = Convert.ToChar(Console.ReadLine());
            if(accounts.Transaction_type == 'C')
            {
                Console.WriteLine("Enter your Amount: ");
                accounts.amount=int.Parse(Console.ReadLine());
                accounts.credit(accounts.amount);
            }
            else
            {
                Console.WriteLine("Enter your Amount: ");
                accounts.amount = int.Parse(Console.ReadLine());
                accounts.debit(accounts.amount);

            }


            accounts.display();
        }
    }
}
