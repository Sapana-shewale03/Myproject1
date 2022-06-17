using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.ArrayDemo
{
    class CharArrayDisplay
    {
        static void Main(string[] args)
        {

        char[] a = { 'a', 'b', 'c', 'd', 'e' };
            Console.WriteLine(string.Join(" ",a));
        char[] a1 = new char[5];
        for(int i=0;i<a1.Length;i++)
            {
                a1[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("***********************");
        foreach(char m in a1)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine("*****************************");
           for(int j=0;j<a1.Length;j++)
            {
                Console.WriteLine(a1[j]);
            }
            Console.WriteLine("**********************");
            Console.WriteLine(string.Join(" ",a1));
        }
    }
    ///////display int array
    class IntArrayDisplay
    {
        static void Main(string[] args)
        {

            int[] m = { 1,2,3,5,6 };
            Console.WriteLine(string.Join(" ", m));
            int[] m1 = new int[5];
            for (int i = 0; i < m1.Length; i++)
            {
                m1[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("***********************");
            foreach (int f in m1)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine("*****************************");
            for (int j = 0; j < m1.Length; j++)
            {
                Console.WriteLine(m1[j]);
            }
            Console.WriteLine("**********************");
            Console.WriteLine(string.Join(" ", m1));
        }
    }
}
