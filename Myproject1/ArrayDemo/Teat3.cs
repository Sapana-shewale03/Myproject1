using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.ArrayDemo
{//create a Array of integer and count the number of even  and odd elements from array.
    class Teat3
    {
        static void Main(string[] args)
        {

            int[] m = new int[6]; int i;int count=0;int count1 = 0;
            for (i = 0; i < m.Length; i++)
            {
                m[i] = Convert.ToInt32(Console.ReadLine());
                if (m[i] % 2 == 0)
                {
                    count++;
                }
                else
                {
                    count1++;
                }
            }
            Console.WriteLine("even number "+count);
            Console.WriteLine("odd numbers "+count1);
        }
    }
    ///////2.error sq barces at wrong place
    ///3Write a program to find Minimum frequency char from an Array
    // e.g char arr[] = {‘a’,’b’,’b’,’c’,’c’,’b’};
    // output= a
    class minfreq
    {
        static void Main(string[] args)
        {
            char[] a = { 'a', 'b', 'b', 'c', 'c', 'b' };
            Console.WriteLine(string.Join(" ", a));
            char[] a1 = new char[5];
            /*  for (int i = 0; i < a1.Length; i++)
              {
                  a1[i] = Convert.ToChar(Console.ReadLine());
              }*/
            Console.WriteLine("**********************");
            Console.WriteLine(string.Join(" ", a1));
            for (int i = 0; i < a1.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i; k > 0; k--)
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
                    Console.WriteLine(a[i] + " " + count);
                    if (count > 1)
                    {
                        Console.WriteLine(a[i] + " " + count);
                    }
                }

            }
        }
    }
    ////////4.property pen nib

    public class Refill
    {
        string inkcolor;
        int len;
        public string Inkcolor
        {
            get { return inkcolor; }
            set { inkcolor = value; }
        }
        public int Len
        {
            get { return len; }
            set { len = value; }
        }
        public void display()
        {
            Console.WriteLine(Inkcolor + " " + Len);
        }
    }
    class Nib
    {
        string nib;
        int wd;
        public string Nb
        {
            get { return nib; }
            set { nib = value; }
        }
        public int Wd
        {
            get { return wd; }
            set { wd = value; }
        }
        public void show()
        {
            Console.WriteLine(nib + " " + wd);
        }
    }
    class Pen
    {
        static void Main(string[] args)
        {
            Nib n = new Nib();
            n.Nb = "alluminium";
            n.Wd = 3;
            n.show();
            Refill r = new Refill();
            r.Inkcolor = "PINK";
            r.Len = 3;
            r.display();
        }
    }
    /////5.remove zeros and add to end
    class SeperatZeros
    {
        static void remozero(int[] a, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
                if (a[i] != 0)
                {
                    a[count++] = a[i];
                }
            while (count < n)
            {
                a[count++] = 0;
            }
        }
        public static void Main()
        {
            int[] a = { 12, 0, 7, 0, 8, 0, 3 };
            Console.WriteLine(string.Join(" ", a));
            int n = a.Length;
            remozero(a, n);
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
        }
    }
    /////6.remove duplcate eelments from aray
    class Duplicatearr
    {

        static void Main(string[] args)
        {
            int[] a = new int[6];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
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
                Console.WriteLine(final[i]);
            }
            Console.ReadLine();
        }
    } 
    ///////7.car engn subengn
    class subengin
    {
        string subengintype;
        public subengin(string subengintype)
        {
            this.subengintype = subengintype;
        }
        public void show()
        {
            Console.WriteLine("engin type " + subengintype);
        }
    }
        class Engintest
        {
            int eidtest;
            string lastcleanupdate;
            subengin sub;
            public Engintest(int eidtest,string lastcleanupdate,subengin sub)
            {
                this.eidtest = eidtest;
                this.lastcleanupdate = lastcleanupdate;
                this.sub = sub;
            }
            public void display()
            {
                Console.WriteLine("id of engin"+eidtest+"last cleanup date "+ lastcleanupdate);
                sub.show();
            }
        }class Gear
        {
            string type;
                public Gear(string type)
            {
                this.type = type;
            }
            public void showGear()
            {
                Console.WriteLine("gear tyep "+type);
            }
        }
        class car
        {
            int carid;
            string carcolor;
            Engintest en;
            Gear g;
            public car(int carid,string carcolor, Engintest en,Gear g)
            {
                this.carid = carid;
                this.carcolor = carcolor;
                this.en = en;
                this.g = g;
            }
            public void Prnt()
            {
                Console.WriteLine("car id  "+carid+"carcolor "+carcolor);
                en.display();
                g.showGear();
            }
        }
        class Carnifo
        {
            static void Main(string[] args)
            {
                car c = new car(12,"black",new Engintest(13,"12/2/2011",new subengin("petrol")),new Gear("Manual"));
               // car c = new car();
            c.Prnt();
            }
        }
    
    ////////8.error n array decl
    ///9.. arr[] = [23, 43, 25, 49, 12, 9, 78, 66, 39, 0] so output is 25, 49, 9
   class PerfsqArray
    {
        static void Main(string[] args)
        {
            int[] a = { 23, 43, 25, 49, 12, 9, 78, 66, 39, 0 };
            int i;int r, psq;           
               foreach(int m in a)
                {
                for (i = 1; i < m; i++)
                {
                    if (i * i == m)
                    {
                        Console.WriteLine("perfect sq s " + m);

                    }
                }
            }
            Console.WriteLine();
        }
    }

}



