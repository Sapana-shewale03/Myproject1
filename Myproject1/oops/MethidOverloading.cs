using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.oops
{
    class MethidOverloading
    {
        void arithmatic(int a,int b)
        {
            Console.WriteLine("Addition of number is :"+(a+b));
        }

        void arithmatic(int a, double b)
        {
            Console.WriteLine("subtraction  of number is :" + (a - b));
        }

        void arithmatic(double a, int b)
        {
            Console.WriteLine("multiplication of number is :" + (a * b));
        }

        void arithmatic(float a, int b)
        {
            Console.WriteLine("division of number is :" + (a / b));
        }

        static void Main(string[] args)
        {
            MethidOverloading m = new MethidOverloading();
            m.arithmatic(2, 4);
            m.arithmatic(2, 4.5);
            m.arithmatic(2.4, 4);
            m.arithmatic(4.4f, 2);

        }
    }
    //////// overload area
   class OverloadingArea
    {
        void Area(int r)
        {
            Console.WriteLine("Area of circle is :"+(3.14*r*r));
        }

        void Area(float l,double w)
        {
            Console.WriteLine("Area of rectangle is :"+(l*w));
        }

        void Area(int b, int h)
        {
            Console.WriteLine("Area of triangle is :"+(0.5*h*b));
        }

        void Area(float l)
        {
            Console.WriteLine("Area of square :"+(l*l));
        }

        static void Main(string[] args)
        {
            OverloadingArea a = new OverloadingArea();
            a.Area(4);
            a.Area(4.3f,5.6);
            a.Area(3,5);
            a.Area(4.5f);
        }
    }
    ///// overloading static method
    class OverloadingStaticMethod
    {
        static void Overlo()
        {
            Console.WriteLine("hello");
        }

       static void  Overlo(int a,int b)
        {
            Console.WriteLine("addition is :"+(a+b));
        }
        static void Main(string[] args)
        {
            OverloadingStaticMethod.Overlo();
            OverloadingStaticMethod.Overlo(2,4);
        }
    }
    /////////static class contain constructor and call constructor
   static class StatiCconst
    {
        static  StatiCconst()
        {
            Console.WriteLine("hello");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" WorLd");
        }
    }
    /////// CONSTRUCTOR OVERLOADING
    class consover
    {
        public  consover()
        {
            Console.WriteLine("hello");
        }
        public  consover(int a,int b)
        {
            Console.WriteLine("addition is :"+(a+b));
        }
        static void Main(string[] args)
        {
            consover c = new consover();
            consover c1 = new consover(3,4);

        }
    }
}
