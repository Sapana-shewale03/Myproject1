using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.ArrayDemo
{
    class array_sort
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 7, 3, 4, 1 };
            Console.WriteLine(string.Join(" ",a));
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(" ",a));
        }
    }
}
