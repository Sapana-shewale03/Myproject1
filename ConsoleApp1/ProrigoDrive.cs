using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp
{
    class ProrigoDrive
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 4, 5, 2, 7, 8 };
            //o/p== 2,7,8,3,4,5
            int j = (a.Length)/2;
           Console.WriteLine(a[j]);
            Console.WriteLine(string.Join(" ", a));
            for (int i=0;i<a.Length/2;i++)
            {
                    int temp = a[i];
                    a[i] = a[i+j];
                    a[i+j] = temp;
            }
            Console.WriteLine(string.Join(" ", a));
        }
    }
    /// anagram string
    class anstring
    {
        public void angastring(string m,string n)
        {
            string j = m.ToLower();
            string i = n.ToLower();

            char[] ch1 = j.ToCharArray();
            char[] ch2 = i.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string a = new string(ch1);
            string b = new string(ch2);
            if(a==b)
            {
                Console.WriteLine("string is anagram");
            }
            else
            {
                Console.WriteLine("not angaram");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter first string");
            string s = Console.ReadLine();
            Console.WriteLine("enter 2nd string");
            string c = Console.ReadLine();
            anstring an = new anstring();
            an.angastring(s, c);
        }
    }
    ///cuckoo
    class Cuckoo
    {
        int coo(int s)
        {
            if (s == 1)
            {
                s = 0;
            }
           else if (s == 2)
            {
                s = 1;
            }

            return s;
        }
        static void Main(string[] args)
        {


            Cuckoo ck = new Cuckoo();
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            int cu1 = 0;
            int cu2 = 1;

            if (n == 1)
            {
                Console.WriteLine("0");
            }
            else if (n == 2)
            {
                Console.WriteLine("1");

            }
            else if (n > 2)
            {
                
                    c = 1 * ck.coo(n - 1) + 2 * ck.coo(n -2) + 3 * 1;
                
                Console.WriteLine(c);
            }
        }
    }
    ///coprime
    class Coprime
    {
        public void cp(int n)
        {
            int gcd = 0;
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int divisor = 1; divisor <i; divisor++)
                {
                    if (n % divisor == 0 && i % divisor == 0)
                        gcd = divisor;
                }

                if (gcd == 1)
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
        int n = Convert.ToInt32(Console.ReadLine());
            Coprime c = new Coprime();
            c.cp(n);
         }
    }
    /// array length max
    class subarray
    {
        public void suba(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            int j;
            int max = 0;
            int zero, ones;
            // int r = 0;
            //Find Largest subarray length have equal zero and one 

            for (int i = 0; i < arr.Length; i++)
            {
                zero = 0;
                ones = 0;
                for (j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                        zero++;
                    else
                        ones++;

                    if (zero == ones)
                    {
                        // r =zero + ones;
                        max = max > (j - i + 1) ? max : j - i + 1;
                    }
                }
            }
            Console.WriteLine(max);
        }
        static void Main(string[] args)
        {
            //Accept Size
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            //Accept data
            subarray s = new subarray();
            s.suba(a);



        }
    }
}


