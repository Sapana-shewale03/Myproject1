using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.ArrayDemo
{
    class SumOfPrime
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int sum = 1;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                for (int j = 2; j <=9; j++)
                {
                    if ((i % j) == 0)
                    {
                        sum = sum + i;
                    }
                }
            }
            Console.WriteLine("**************");
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine("sum of prime number is :" +sum);         
        }
    }
   ////////alternate element from array
   class AlternateArray
    {
        static void Main(string[] args)
        {
            int[] m = new int[6];int i;
            for (i = 0; i < m.Length; i++)
            {
                m[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("**********************");
            Console.WriteLine("Array is...");
           Console.WriteLine(string.Join(" ",m));
            Console.WriteLine("aletrnate numbers of array:");

            for (int j=0;j<m.Length;j++)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(string.Join(" ", m[j]));
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
    //////min and maximun from array
    class MinMax
    {
        static void Main(string[] args)
        {
            int[] n = new int[5]; 
            int i; 
            for (i = 0; i < n.Length; i++)
            {
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = n[0];
            int min = n[0];

            for (int j =0;j<n.Length;j++)
            {
                if(n[j]>max)
                {
                    max = n[j];
                }
                else if(n[j]<min)
                {
                    min = n[j];
                }
            }
            Console.WriteLine("***************");
            Console.WriteLine(string.Join(" ",n));
              Console.WriteLine("min is "+min);
            Console.WriteLine("max is "+max);
        }
    }
    /////////merging of array
    class mergingofarray
    {
        static void Main(string[] args)
        {
          int[] a = { 1, 5, 3, 6, 7, 8, 6, 9 };
          int[] b = { 31, 12, 45, 34, 87 };
           Console.WriteLine(string.Join(" ",a));
            Console.WriteLine(string.Join(" ", b));
            Console.WriteLine("combine Array element:");
            foreach (int f in a)
            {
                Console.WriteLine(f);
            }
            foreach (int f in b)
            {
                Console.WriteLine(f);
            }      
        }
    }
    /////Array serach
    class ArraySearch
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 5, 6, 6 };
            Console.WriteLine("enter element for search");
            int n = Convert.ToInt32(Console.ReadLine());
            bool ispresent = false;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==n)
                {
                    ispresent = true;
                   // Console.WriteLine("element found");
                }
            }
            if(ispresent==true)
            {
                Console.WriteLine("element is present");
            }
            else
            {
                Console.WriteLine("not present");
            }
        }
    }
    /////////print prime number
    class ArrayPrime
    {
        static void Main(string[] args)
        {
            int[] a = new int[5]; bool isprime = false;
            for (int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("///////////////////");
            for(int i=2;i<a.Length;i++)
            {
                isprime = true;
            }
            if(isprime==true)
            {
                Console.WriteLine("number is prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
    /////Array reverse
    class ReverArray
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 4, 6, 7, 8 };
            int j = a.Length - 1;
            Console.WriteLine(string.Join(" ",a));
            for(int i=0;i<a.Length/2;i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(" ",a));
        }
    }
    /////// frequency of element
    class frequencyele
    {
        static void Main(string[] args)
        {
            int[] a = { 2,4,34,2,6,4};
            Console.WriteLine(string.Join(" ",a));
            for(int i=0;i<a.Length;i++)
            {
                int count = 1;
               bool isvisited = false;
                for(int k=i;k>0;k--)
                {
                    if(a[i]==a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                        if(a[i]==a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i]+" "+count);
                    if(count>1)
                    {
                        Console.WriteLine(a[i]+" "+count);
                       
                    }
                   
                }
                
            }
        }
    }
}
