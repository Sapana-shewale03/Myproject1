using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.condition
{
    class electricitybill
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter electricity bill");
            double eb = Convert.ToDouble(Console.ReadLine());
            double total;
            if(eb < 50)
            {
                total = eb * 0.50;
                Console.WriteLine(" bill is" + total);
            }
            else if(eb<150 && eb>50 )
            {
                total = eb + (eb - 50) * 0.75;
                Console.WriteLine(" electricity bill is  " + total);
            }
            else if(eb<200 && eb>100)
            {
                total = eb + (eb - 150) * 1.20;
                Console.WriteLine("electricity bill is consumed  " + total);
            }
            else if(eb > 250 && eb >200)
            {
                total = eb + (eb - 200) * 1.50 + (20 / 100);
                Console.WriteLine("electricuity bill is consumed by cost  " + total);

            }

        }
    }
}
