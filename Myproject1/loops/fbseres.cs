using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.loops
{
    class fbseres
    {
        static void Main(string[] args)
        {

                int sum = 0, g = 1, prev = 0;
                for (int i = 0; i <= 10; i++)
                {
                    prev = sum + prev;
                    Console.WriteLine(prev);
                    sum = g;
                    g = prev;
                }
            
        }
    }
    /// code for dsplay sum of even number
    /// 
    class evenadd
    {
        static void Main(string[] args)
        {

            int sum = 0;
            Console.WriteLine("even number between 1 to 10 are ");
            for (int i = 1; i <= 10; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of even numbers s "+sum);
        }
    }

    //// prg for no of odd numbers between 1 to 20
    class odddnumber
    {
        static void Main(string[] args)
        {

            int sum = 0;
            Console.WriteLine("odd numbers between 1 to 20 are ");
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;

                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("number of odd number is "+sum);
        }
    }
    ///table of even number
    class tableofevenno
    {
        static void Main(string[] args)
        {

            int tbl = 1;
            Console.WriteLine("enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                tbl = i * n;
                Console.WriteLine(+n + "x" + i + "=" + tbl);
                    
                
            }
        }
    }
    ///dsplay 25 to 15
    class toddnumberdp
    {
        static void Main(string[] args)
        {
            for (int i = 25; i >= 15; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
    ///// 350 to 400 

    class moddnumberdp
    {
        static void Main(string[] args)
        {
            for (int i = 350; i <= 400; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    ///// odd number between 15 to 30
    class woddnumberdp
    {
        static void Main(string[] args)
        {
            for (int i = 15; i <= 30; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
