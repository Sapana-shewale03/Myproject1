using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.condition
{
    class salary
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter basic salary");
            int bs = Convert.ToInt32(Console.ReadLine());
            double gs;

            if(bs <= 10000)
            {
                gs = bs + ((20*bs) / 100 ) + ((80*bs) / 100);

                Console.WriteLine(+gs+ "  is gross salry     ");
            }
            else if(bs <= 20000)
            {
                gs = bs + ((25*bs)/100) + ((70*bs)/100);
                Console.WriteLine(+gs+ " is grass salary for basic salary"+bs);
            }
            else if(bs  > 20000)
            {
                gs = bs + ((30*bs) / 100) + ((95*bs) / 100);
                Console.WriteLine(+gs + " is gs for basic salary");
            }

        }
    }
}
