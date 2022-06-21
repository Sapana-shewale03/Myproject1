using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.ArrayDemo
{
    class ArrayMethod
    {
        public void sumofarray(int[] arr)
        {
            Console.WriteLine(arr.GetHashCode());
            int sum = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] % 2 == 0)
                {
                    sum = sum + arr[j];
                }
            }
            Console.WriteLine("addton of array:" + sum);
        }
        static void Main(string[] args)
        {
            int[] n = { 2, 5, 7, 4, 9 };
            ArrayMethod m = new ArrayMethod();
            m.sumofarray(n);
            Console.WriteLine(m.GetHashCode());
        }
    }
    //////reverse array usng method
    class Reverseclas
    {
        public int[] ReverseArray(int []revers)
        {
            int j = revers.Length - 1;
            for(int i=0; i<revers.Length/2;i++)
            {
                int temp = revers[i];
                revers[i] = revers[j];
                revers[j] = temp;
                j--;
            }
            return revers;
        }
        static void Main(string[] args)
        {
            int[] a = { 4, 2, 6, 5, 9 };
            Console.WriteLine(string.Join(" ",a));
            Reverseclas m = new Reverseclas();
            int []b = m.ReverseArray(a);
            Console.WriteLine(string.Join(" ",b));
        }
    }
}
