using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5
{
    internal class Furniture
    {
        public int OrderId;
        public DateTime OrderDate;
        public string FurnitureType;
        public int Qty;
        public int TotalAmt;
        public string PaymentMode;


    }
    class Cot : Furniture
    {
        public string CotType;
        public string Capacity;
        public string type;
        public int Rate;

        

            public void GetData(string CotType, string Capacity, string type, int Rate)
            {
                this.CotType = CotType;
                this.Capacity = Capacity;
                this.type = type;
                this.Rate = Rate;
            }
            public void ShowData()
            {
                Console.WriteLine("CotType: {0}", CotType);
                Console.WriteLine("Capacity:{0}", Capacity);
                Console.WriteLine("type: {0}", type);
                Console.WriteLine("rate: {0}", Rate);
            }


        }
    class Chair : Furniture
    {
        public string ChairType;
        public string purpose;
        public string type;
        public int rate;

        public void GetData(string ChairType,string purpose,string type,int rate)
        {
            this.ChairType = ChairType;
            this.purpose = purpose;
            this.type = type;
            this.rate = rate;
        }
        public void ShowData()
        {
            Console.WriteLine("ChairType: {0}", ChairType);
            Console.WriteLine("purpose:{0}",purpose);
            Console.WriteLine("type: {0}",type);
            Console.WriteLine("rate: {0}",rate);
        }
    }
    class Demo
    {
        public static void Main()
        {

            Console.WriteLine("Choose Your Furniture Type: ");
            Console.WriteLine("1. Chair");
            Console.WriteLine("2.Cot");
            int furnitureType=int.Parse(Console.ReadLine());

            switch (furnitureType)
            {
                case 1:
                    Chair chair = new Chair();
                    Console.WriteLine("Choose your ChairType: ");
                    Console.WriteLine("1. Wood");
                    Console.WriteLine("2. Steel");
                    Console.WriteLine("3. Plastic");
                    int chairType=int.Parse(Console.ReadLine());
                    string chairTypeValue = null;
                    int type;
                    string typeValue = null; ;
                    Console.WriteLine("Choose your Purpose: ");
                    Console.WriteLine("1. Home");
                    Console.WriteLine("2. Office");
                    int purpose=int.Parse(Console.ReadLine());
                    string purposeValue;
                    if (purpose == 1)
                    {
                        purposeValue = "Home";
                    }
                    else
                    {
                        purposeValue = "Office";
                    }
                    switch (chairType)
                    {
                        case 1:
                            chairTypeValue = "Wood";
                            Console.WriteLine("Choose your Wood type");
                            Console.WriteLine("1.Teak Wood");
                            Console.WriteLine("2.Rose Wood");
                            type=int.Parse(Console.ReadLine());
                            switch (type)
                            {
                                case 1:
                                    typeValue = "Teak Wood";
                                    break;
                                case 2:
                                    typeValue = "Rose Wood";
                                    break ;
                                default:
                                    Console.WriteLine("Wrong choice selected");
                                    break;
                            }
                            break;
                        case 2:
                            chairTypeValue = "Steel";
                            Console.WriteLine("Choose your steel type");
                            Console.WriteLine("1.Grey steel");
                            Console.WriteLine("2.Green steel");
                            Console.WriteLine("3.Brown Steel");
                            type = int.Parse(Console.ReadLine());
                            switch (type)
                            {
                                case 1:
                                    typeValue = "Grey steel";
                                    break;
                                case 2:
                                    typeValue = "Green Steel";
                                    break;
                                case 3:
                                    typeValue = "Brown Steel";
                                    break;
                                default:
                                    Console.WriteLine("Wrong choice selected");
                                    break;
                            }
                            break;
                        case 3:
                            chairTypeValue = "Plastic";
                            Console.WriteLine("Choose your chair color");
                            Console.WriteLine("1.Green");
                            Console.WriteLine("2.Red");
                            Console.WriteLine("3.Blue");
                            Console.WriteLine("4.White");
                            type=int.Parse(Console.ReadLine());
                            switch (type)
                            {
                                case 1:
                                    typeValue = "Green";
                                    break;
                                case 2:
                                    typeValue = "Red";
                                    break;
                                case 3:
                                    typeValue = "Blue";
                                    break;
                                case 4:
                                    typeValue = "White";
                                    break ;
                                default:
                                    Console.WriteLine("Wrong choice selected");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Wrong choice");
                            break;

                            
                    }
                    Console.WriteLine("Enter the rate for chair: ");
                    int chairRate=int.Parse(Console.ReadLine());
                    chair.GetData(chairTypeValue, purposeValue, typeValue, chairRate);
                    chair.ShowData();




                break;
                case 2:
                    Cot cot= new Cot();
                    Console.WriteLine("Choose your CotType: ");
                    Console.WriteLine("1. Wood");
                    Console.WriteLine("2. Steel");
                    int cotType=int.Parse(Console.ReadLine());
                    string cotTypeValue = null;
                    typeValue = null;
                    
                    
                    
                    switch (cotType)
                    {
                        case 1:
                            cotTypeValue = "Wood";
                            Console.WriteLine("Choose your Wood type");
                            Console.WriteLine("1.Teak Wood");
                            Console.WriteLine("2.Rose Wood");
                            type=int.Parse(Console.ReadLine());
                            switch (type)
                            {
                                case 1:
                                    typeValue = "Teak Wood";
                                    break;
                                case 2:
                                    typeValue = "Rose Wood";
                                    break ;
                                default:
                                    Console.WriteLine("Wrong choice selected");
                                    break;
                            }
                            break;
                         case 2:
                            cotTypeValue = "Steel";
                            Console.WriteLine("Choose your steel type");
                            Console.WriteLine("1.Grey steel");
                            Console.WriteLine("2.Green steel");
                            Console.WriteLine("3.Brown Steel");
                            type = int.Parse(Console.ReadLine());
                            switch (type)
                            {
                                case 1:
                                    typeValue = "Grey steel";
                                    break;
                                case 2:
                                    typeValue = "Green Steel";
                                    break;
                                case 3:
                                    typeValue = "Brown Steel";
                                    break;
                                default:
                                    Console.WriteLine("Wrong choice selected");
                                    break;
                            }

                            break;


                    }
                    Console.WriteLine("Enter the capacity: ");
                    Console.WriteLine("1.Single");
                    Console.WriteLine("2.Double");
                    int capacity=int.Parse(Console.ReadLine());
                    string CapacityValue = null;
                    if (capacity == 1)
                    {
                        CapacityValue="Single";

                    }
                    else
                    {
                        CapacityValue="Double";
                    }
                    Console.WriteLine("Enter the rate: ");
                    int rate=int.Parse(Console.ReadLine());
                    cot.GetData(cotTypeValue,CapacityValue,typeValue,rate);
                    cot.ShowData();

                    
                    break;
                    Console.WriteLine("Enter your orderId: ");





            }
        }
    }
    
}
