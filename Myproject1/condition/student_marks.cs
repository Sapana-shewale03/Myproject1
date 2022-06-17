using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.condition
{
    class student_marks
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter maeks of five subjects");
            double m1 = Convert.ToDouble(Console.ReadLine());
            double m2 = Convert.ToDouble(Console.ReadLine());
            double m3 = Convert.ToDouble(Console.ReadLine());
            double m4 = Convert.ToDouble(Console.ReadLine());
            double m5 = Convert.ToDouble(Console.ReadLine());
            double total, avg, perc;


            total = m1 + m2 + m3 + m4 + m5;
            Console.WriteLine("total of marks is  " + total);


            avg = total / 5;
            Console.WriteLine("average of marks is " + avg);

            perc = (total / 5) * 100;
            Console.WriteLine("percentage of marks is   " + perc);
        }

    }
}
