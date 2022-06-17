using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.ArrayDemo
{
    class SumofEven
    {
        static void Main(string[] args)
        {
            int[] m = { 1, 2, 3, 5, 6 };
            Console.WriteLine("Array is ");
            Console.WriteLine(string.Join(" ",m));
            // int[] m1 = new int[5];
            int sum = 0;
            Console.WriteLine("*************************");
            for (int i = 0; i < m.Length; i++)
            {
                if(m[i]%2==0)
                {
                    Console.WriteLine("even numbers are: "+m[i]);
                    sum = sum + m[i];
                }
            }
            Console.WriteLine("sum of even numbers :" + sum);

        }
    }
    ////// odd position eleemnt
    class DisplayOdd
    {
        static void Main(string[] args)
        {
            int[] d = { 1, 2, 3, 5, 6 };
            Console.WriteLine("Array is ");
            Console.WriteLine(string.Join(" ", d));
            Console.WriteLine("*************************");
            Console.WriteLine("odd position value are");
            for (int i = 0; i < d.Length;i=i+2)
            {
                Console.WriteLine(string.Join(" ",d[i]));         
            }
        }
    }
    //////////display sum of all array
    class SumofArray
    {
        static void Main(string[] args)
        {
            int[] m = { 1, 2, 3, 5, 6 };
            Console.WriteLine("Array is ");
            Console.WriteLine(string.Join(" ", m));
            // int[] m1 = new int[5];
            int sum = 0;
            Console.WriteLine("*************************");
            for (int i = 0; i < m.Length; i++)
            {
                    sum = sum + m[i];
            }
            Console.WriteLine("sum of even numbers :" + sum);

        }
    }
}
