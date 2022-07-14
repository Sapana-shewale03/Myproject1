using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.stringDemos
{
    /// <summary>
    /// //////
    /// </summary>
    class Test4
    {
            static void Main(string[] args)
            {
                char[] a = { 'a', 'b', 'b', 'c', 'c', 'b' };
                Console.WriteLine(string.Join(" ", a));
                char[] a1 = new char[5];
                Console.WriteLine("**********************");
                Console.WriteLine(string.Join(" ", a1));
                for (int i = 0; i < a1.Length; i++)
                {
                    int count = 1;
                    bool isvisited = false;
                    for (int k = 0; k < i; k++)
                    {
                        if (a[i] == a[k])
                        {
                            isvisited = true;
                            break;
                        }
                    }
                    if (isvisited == false)
                    {
                        for (int j = i + 1; j < a.Length; j++)
                        {
                            if (a[i] == a[j])
                            {
                                count++;
                            }
                        }
                        if (count > 1)
                        {
                            Console.WriteLine(a[i] + " " + count);
                        }
                    }
                }
            }
    }
    /////////prg to count number of words in a string
    class countnumberofword
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER ANY STRING");
            string a1 = Console.ReadLine();
            // string[] a1 = a.Split(" ");
            int count = 1;
           int l = 0;
            while (l <= a1.Length - 1)
            {
                if (a1[l] == ' ' || a1[l] == '\n' || a1[l] == '\t')
                {
                    count++;
                }

                l++;
            }

            Console.Write("Total number of words in the string is : "+count);
        }
    }
    /////string is anagarm or not
    class stringanagarm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st string");
            string str = Console.ReadLine();
            Console.WriteLine("enter 2nd string");
            string m1 = Console.ReadLine();

            string s = str.ToLower();
            string m = m1.ToLower();
            
            char[] ch1 = m.ToCharArray();
            char[] ch2 = s.ToCharArray();
          
            Array.Sort(ch1);
            Array.Sort(ch2);
          
            string st1 = new string(ch1);
            string st2=new string(ch2);
            if(st1==st2)
            {
                Console.WriteLine("strings are anagram ");
            }else
            {
                Console.WriteLine("not anagram");
            }
        }
    }
    ///////4.array of 10 name sort in decending order
    class NameSortArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any string");
            string str = Console.ReadLine();
            string[] s = str.Split(" ");
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length - 1; j++)
                {
                    if (s[i].CompareTo(s[j]) ==1)
                    {
                        string temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",s));
        }
    }
    ////5.finf total number of digit alpha and special char
    class StringAlphaDigitchar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter mix string");
            string c= Console.ReadLine();
           // string[] c = a1.Split("");
            char[] a = c.ToCharArray();
            int l = 0;int alphacount = 0;int digitcount = 0;int charcount = 0;
            while (l <= a.Length - 1)
            {
                if((a[l]>='A' && a[l]<='Z')||(a[l] >= 'a' && a[l] <= 'z'))
                {
                    alphacount++;
                }
                else if(a[l]>='0' && a[l]<='9')
                {
                    digitcount++;
                }
                else
                {
                    charcount++;
                }
                l++;
            }
            Console.WriteLine("alphabets are : "+alphacount);
            Console.WriteLine("digits are : " + digitcount);
            Console.WriteLine("special char  are : " + charcount);

        }
    }
    //////6.uppercase to lowercase
    class StringUpperLower
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
           // string[] str = s.Split(" ");
            int l = 0;
            string temstr = ""; 
            while (l <= s.Length - 1)
            {
                if (s[l] >= 'A' && s[l] <= 'Z')
                {
                    temstr = temstr +( (char)(s[l]+32));
                }
                if (s[l] >= 'a' && s[l] <= 'z')
                {
                    temstr = temstr + ((char)(s[l] - 32));
                }
                l++;
            }
            Console.WriteLine(temstr);
        }
    }
    //////reverse array without using temp array
    class StringReveerse
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];int rev ;
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",a));
            for (int i = 0; i < a.Length/2; i++)
            {
                    rev = a[a.Length-i-1];
                    a[a.Length-i-1] = a[i];
                    a[i] = rev;
            }
            Console.WriteLine(string.Join(" ",a));
        }
    }
    //////merging of array inn3rd array without repeting elemtns
    class MergeArray
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 4, 5, 6, 7 };
            int[] b = { 1, 0, 11, 2, 4, 65, 4 };
            int[] c = new int [ a.Length + b.Length ];
            int m = 0;
            Console.WriteLine(string.Join(" ",a));
            Console.WriteLine(string.Join(" ",b));
            for (int i=0;i<a.Length;i++)
            {
                c[m] = a[i];
                m++;
            }
            for(int i=0;i<b.Length;i++)
            {
                c[m] = b[i];
                m++;
            }
            for(int i=0;i<c.Length;i++)
            {
                Console.Write(c[i]+" ");
            }
            int count1 = 6;
            int[] final = new int[20];
            int s = 0;
            for (int i = 0; i < c.Length; i++)
            {
                int count = 1;

                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (c[i] == c[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < c.Length; j++)
                    {
                        if (c[i] == c[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        final[s] =c[i];
                        s++;
                    }
                }
            }
            Console.WriteLine("\n***********");
            Console.WriteLine("after removing duplicate elements");
            for (int i = 0; i < s; i++)
            {
                Console.Write(" " + final[i]);
            }
            Console.ReadLine();
        }
    }
    ///////9.ascending order
    class acsendingstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any string ");
            string a = Console.ReadLine();
            string[] s = a.Split(" ");
            string rev = "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length - 1; j++)
                {
                    if (s[i].CompareTo(s[j]) == -1)
                    {
                        string temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",s));
        }
    }
    //////10.replace all 0 with 1
    class StringReplace0with1
    {
        static void Main(string[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            Console.WriteLine(string.Join(" ",a));
            for (int i = 0; i < a.Length-1; i++)
            {
                if (a[i] == 0)
                {
                    int rev = a[i];
                    a[i] = 1;
                }
            }
            Console.WriteLine(string.Join(" ", a));

        }
    }
    /////11.Means arr[] = [12, 3,
    ////////-19, 29, 5, -61, 44, 7, -9] Output array will be[12, 3, 9, 29, 5, 25, 44, 7, 49].
    class StringReplaceleftelemsq
    {
        static void Main(string[] args)
        {
            int[] a = { 12,3,-19, 29, 5, -61, 44, 7, -9 };
            Console.WriteLine(string.Join(" ", a));
            int sq=1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]<=0)
                {
                    a[i]= a[i-1]*a[i-1];
                }
            }
            Console.WriteLine(string.Join(" ", a));
        }
    }
    ////12.min char from array
    class ArrayMinChar
    {
        static void Main(string[] args)
        {
            char[] a = { 'A', 'D', 'E', 'x', 'z', 'R' };
            Console.WriteLine(string.Join(" ", a));
            char max = 'z';
            for (int i = 0; i < a.Length; i++)
            {
               if(a[i]<max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine(max);
        }
    }
    //////13.unique elemnt from array
    class ArrayUnique
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any array ");
            int[] a = new int[6];
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",a));
            int count1 = 6;
            int[] final = new int[20];
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;

                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        final[s] = a[i];
                        s++;
                    }
                }
            }
            Console.WriteLine("***********");
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine(" unique element is " + final[i]);
            }
            Console.ReadLine();
        }
    }
    ////1.find sum
    class sumelement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st numbwer");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd numbwer");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("sum of "+a+" and "+b+" is "+sum);
        }
    }
    //// all arithmatitic operation and seperate prg
    class sumelement1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st numbwer");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd numbwer");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("sum of " + a + " and " + b + " is " + sum);
        }
    }
    ////2.
    class subelement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st numbwer");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd numbwer");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a - b;
            Console.WriteLine("subtraction of " + a + " and " + b + " is " + sum);
        }
    }
    ////3.
    class mulelement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st numbwer");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd numbwer");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a * b;
            Console.WriteLine("multiplication of " + a + " and " + b + " is " + sum);
        }
    }
    ///4.
    class divelement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st numbwer");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd numbwer");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a / b;
            Console.WriteLine("division of " + a + " and " + b + " is " + sum);
        }
    }
    ////5.
    class modelement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st numbwer");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd numbwer");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a % b;
            Console.WriteLine("mod of " + a + " and " + b + " is " + sum);
        }
    }
    ///3.find area of rectangle enght and bridth
    class AreaRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth");
            int b = Convert.ToInt32(Console.ReadLine());
            int area = a * b;
            Console.WriteLine("area of reactngle  is " + area);
            int peri = a +a + b + b;
            Console.WriteLine("perimeter of reactngle  is " + peri);

        }
    }
    ////4.find area of tringle
    class AreaTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth");
            int b = Convert.ToInt32(Console.ReadLine());
            int area = (a * b)/2;
            Console.WriteLine("area of triangle  is " + area);
        }
    }
    /////5.sq and cube
    class BasicPrg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth");
            int b = Convert.ToInt32(Console.ReadLine());
            int sq = a * a;
            Console.WriteLine("sq of "+a+"is " + sq);
            int cb = b *b* b;
            Console.WriteLine("cube of " + b + "is " + cb);
        }
    }
    ////enter length in cm convertit into m and km
    class convertintokm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length");
            int l = Convert.ToInt32(Console.ReadLine());
            float m = l / 100f;
            Console.WriteLine("length in meter " + m);
            int km = l *100000;
            Console.WriteLine("length in km " + km);
        }
    }
    //// five student toatl avg and perc
    class studentmarks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 5 subjects marks");
            int m1 = Convert.ToInt32(Console.ReadLine());
            int m2= Convert.ToInt32(Console.ReadLine());
            int m3= Convert.ToInt32(Console.ReadLine());
            int m4= Convert.ToInt32(Console.ReadLine());
            int m5= Convert.ToInt32(Console.ReadLine());

            int total =m1+m2+m3+m4+m5;
            Console.WriteLine("total amrks of 5 sub are " + total);
            float avg = total/5f;
            Console.WriteLine("avg of marks " + avg);
            float perc = (total * 100) / 500f;
            Console.WriteLine("perc of 5 sub are "+perc);
        }
    }
    /////calculate simple intrest
    class csimpleinterst
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter principle,time,rate of interest");
            int p= Convert.ToInt32(Console.ReadLine());
            int t = Convert.ToInt32(Console.ReadLine());
            double r = Convert.ToDouble(Console.ReadLine());
            double si = p*t*r;
            Console.WriteLine("length in meter " + si);
        }
    }
}

