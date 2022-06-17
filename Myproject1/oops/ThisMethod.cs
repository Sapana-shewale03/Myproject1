using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.oops
{
    class ThisMethod
    {
        int x;
        public ThisMethod(int x)
        {
            this.x = x;
            this.show();
        }
        public ThisMethod():this(45)
        {
            Console.WriteLine("default constructor");
        }
        public void show()
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            ThisMethod t = new ThisMethod();
           
        }
    }
    ////// shopping list program
    class ShoppingDetail
    {
        string pitem;
        int sprize;
        int squntity;
        int result;
        public  ShoppingDetail(string item, int prize, int squnt)
        {
            pitem = item;
            sprize = prize;
            squntity = squnt;
        }
        public int  Getbill()
        {
            if (squntity > 0)
            {
                this.show();
                 result = squntity * sprize;
                Console.WriteLine(" total bill is " + result);
                Console.WriteLine();
                return result;
            }
            else
            {             
                Console.WriteLine(" ERROR ");
                return 0;
            }
        }
        public void show()
        {
            Console.WriteLine("purchase item : "+pitem+"\nprize : "+sprize +"\nquntity of product: "+squntity);
           // Console.WriteLine("total bill is " +Getbill());
        }
        static void Main(string[] args)
        {
            ShoppingDetail S = new ShoppingDetail("shirt", 2000,0);
            S.Getbill();
          //  S.show();
        }
    }
}
