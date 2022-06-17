using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.condition.condton_assg_from_vIdeos
{/// <summary>
 /// . A bank intends to design a program to display the denomination of an input amount. 
 /// The available denomination with the bank are of rupees 2000, 500, 200, 100, 50, 20, 10 and 1.
 /// </summary>
    class assgnment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eneter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int r=0; int count = 0; int count1 = 0; int count2 = 0;
            int count3 = 0; int count4 = 0; int count5 = 0;
            int count6 = 0;
            int count7 = 0;

            while (n>2000)
            {
                count++;
                n = n - 2000;
                //break;
            }

            while (n>500)
            {
                count1++;
                n = n - 500;
            }
            while (n > 200)
            {
                count2++;
                n = n - 200;
            }
            while (n > 100)
            {
                count3++;
                n = n - 100;
            }
            while (n > 50)
            {
                count4++;
                n = n - 50;
            }
            while (n > 20)
            {
                count5++;
                n = n - 20;
            }
            while (n > 10)
            {
                count6++;
                n = n - 10;
            }
            while(n>0)
            {
                count7++;
                n = n - 1;
                
            }
            Console.WriteLine("2000 denomnaton is : " + count);
            Console.WriteLine("500 denomnaton is : " + count1);
            Console.WriteLine("200 denomnaton is : " + count2);
            Console.WriteLine("100 denomnaton is : " + count3);
            Console.WriteLine("50 denomnaton is : " + count4);
            Console.WriteLine("20 denomnaton is : " + count5);
            Console.WriteLine("10 denomnaton is : " + count6);
            Console.WriteLine("1 denomnaton is : " + count7);





        }
    }
}
