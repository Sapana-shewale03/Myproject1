using System;
using System.Collections.Generic;

namespace Advancecsharp
{
    class staticProgram
    {
        public void min(int[] arr)
        {
            int i;int count= 1;
            bool isvisited = false;
            for (i = 0; i < arr.Length; i++)
            {

                count = 1;
                isvisited = false;
                for (int k = i; k >=0; k--)
                {
                    if (i == k) {
                        continue;
                    }
                    if (arr[i] == arr[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                    
                    if (count > 1)
                    {
                        //Console.WriteLine("elelment of array " + arr[i] + "  occurace  " + count + " times");

                    }
                    Console.WriteLine("value of array is" + arr[i]);
                    Console.WriteLine(count);
                    Console.WriteLine(isvisited);
                }
                //Console.WriteLine("iteration of array is" + i);
               

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter array");
            int[] a = new int[5];
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",a));
            staticProgram s = new staticProgram();
                s.min(a);
        }
    }
    //// anagram string
    class anagrstring
    {
        public void anag(string s,string n )
        {
            string str = s.ToLower();
            string m1 = n.ToLower();

            char[] ch1 = str.ToCharArray();
            char[] ch2 = m1.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string st1 = new string(ch1);
            string st2 = new string(ch2);
            if (st1 == st2)
            {
                Console.WriteLine("strings are anagram ");
            }
            else
            {
                Console.WriteLine("not anagram");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st string");
            string r = Console.ReadLine();
            Console.WriteLine("enter 2nd string");
            string o = Console.ReadLine();
            anagrstring er = new anagrstring();
            er.anag(r,o);
        }
    }
    ///coprime
  /*  class coprime
    {
       public   int numprime(int m, int n)
        {
            int gcd = 0, c = 0;
            for (int i = 1; i <= m; i++)
            {
                if (m % i == 0 || n % i == 0)
                {
                    return 0;
                }

                if (m == n)
                {
                    return m;
                }
                if (m > n)
                {
                    return numprime(m - n, n);
                }
                else
                    return numprime(m, n - a);
            }

            if (numprime(m, n) == 1)
            {
                Console.WriteLine("coprime numner ");
            }
            else
            {
                Console.WriteLine("no  coprime number");

            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int b= Convert.ToInt32(Console.ReadLine());
            coprime cp = new coprime();
            cp.numprime(a,b);

        }
    }*/
    
}
