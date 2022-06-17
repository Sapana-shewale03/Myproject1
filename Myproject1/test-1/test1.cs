using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.test_1
{
    /// <summary>
    /// Area of equvilatral traingle
    /// </summary>
    class test1
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("emter side of eqvilateral triangle");
            double s = Convert.ToDouble(Console.ReadLine());
            double a;
            a = (1.73 * s * s) / 4;
            Console.WriteLine("area of equvilateral triangle is " + a);
        }

    }
    ////////student 5 marks calc total avg perc
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
    ///////// 3.error
    ///////4.leap year
    class leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any year :");
            int y = Convert.ToInt32(Console.ReadLine());

            if (((y % 4 == 0) && (y % 100 == 0)) || (y % 400 == 0))
            {
                Console.WriteLine("year is leap");
            }
            else
            {
                Console.WriteLine("not leap year");
            }
        }
    }
    ///////// 5.number is divisibleny 5 or 11 or not
    class divinoby5or11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any year :");
            int n = Convert.ToInt32(Console.ReadLine());

            if ((n % 5 == 0) && (n % 11 == 0))
            {
                Console.WriteLine("number is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("number is not divisible by 5 and 11");
            }
        }
    }
    //////6.maximum between 3 numbers
    class maxmunum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st num");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd num");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 3rd num");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && b > c)
            {
                Console.WriteLine("greater number is " + a);
            }
            else if (b > c)
            {
                Console.WriteLine("greater number is " + b);

            }
            else
            {
                Console.WriteLine("greter number is " + c);
            }


        }
    }
    //////vowel or conso
    class vowelcons
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enetr any char");
            string ch = Console.ReadLine();

            switch (ch)
            {
                case "a":
                    Console.WriteLine("character is vowel");
                    break;

                case "e":
                    Console.WriteLine("character is vowel");
                    break;
                case "i":
                    Console.WriteLine("character is vowel");
                    break;
                case "o":
                    Console.WriteLine("character is vowel");
                    break;
                case "u":
                    Console.WriteLine("character is vowel");
                    break;
                default:
                    Console.WriteLine("character is consonant");
                    break;

            }
        }

    }
    ///////8. calculator
    class calcutest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" +\n -\n *\n /\n");
            Console.WriteLine("enter your operation symbol");
            string ch = Console.ReadLine();
            Console.WriteLine("enter 1st value");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter 2nd value");
            int b = Convert.ToInt32(Console.ReadLine());


            switch (ch)
            {
                case "+":
                    Console.WriteLine("for + is  " + (a + b));
                    break;

                case "-":
                    Console.WriteLine("for - is   " + (a - b));
                    break;

                case "*":
                    Console.WriteLine("for * is   " + (a * b));
                    break;

                case "/":
                    Console.WriteLine("for / is   " + (a / b));
                    break;
                default:
                    Console.WriteLine("enetr valid value");
                    break;
            }
        }
    }
    ///////9.alp digit char
    class alpdigsym
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter any value");
            char ch = Convert.ToChar(Console.ReadLine());

            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("given value is alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(" value is digit");
            }
            else
            {
                Console.WriteLine("VALUE IS SYMBOL");
            }
        }
    }//////10.even odd prg
    class evneodd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st number");
            int n = Convert.ToInt32(Console.ReadLine());

            if(n % 2 == 0)
            {
                Console.WriteLine("number is even ");
            }
            else
            {
                Console.WriteLine("number s odd");
            }

        }
    }
   
}
