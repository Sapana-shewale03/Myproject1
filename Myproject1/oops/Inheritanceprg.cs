using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.oops
{///sngle inhertancw 1
   class Student
    {
        public void show()
        {
            Console.Write("we are ");
        }
    }
    class Study:Student
    {
        public void display()
        {
            Console.WriteLine(" learning Inheritance");
        }
    }
    class Inheritanceprg
    {
        static void Main(string[] args)
        {
            Study s = new Study();
            s.show();
            s.display();
        }
    }
    /////sngle inhertance 2
    class Mathematcs
    {
        float a = 3.4f; float b = 2.4f;
        public void show()
        {
            Console.WriteLine("float addton "+(a+b));
        }
    }
    class Sub:Mathematcs
    {
        int a = 3;int b = 6;
        public void display()
        {
            Console.WriteLine("Much benefits"+(b-a));
        }
    }
    class Inhertanceex
    {
        static void Main(string[] args)
        {
            Sub t = new Sub();
            t.show();
            t.display();
        }
    }
    ///// multilevel 1
    class Office
    {
        public void show()
        {
            Console.WriteLine(" office has diff dept ");
        }
    }
    class Dept : Office
    {
        public void display()
        {
            Console.WriteLine("departments has employee");
        }
    }
    class Emp1:Dept
    {
        int eid = 12;
        string ename = "Shreya";
        public void Print()
        {
            Console.WriteLine("employee id : "+eid+"\temp name: "+ename);
        }
    }
    class Multprginhe
    {
        static void Main(string[] args)
        {
            Emp1 e = new Emp1();
            e.show();
            e.display();
            e.Print();
        }
    }
    ///// multlevel 2.
    class Father
    {
        public void show()
        {
            Console.WriteLine("Suresh is father who have two child");
        }
    }
    class Son:Father
    {
        public void display()
        {
            Console.WriteLine("1st s son Ridhan,he has sister ");
        }
    }
    class Sister : Son
    {
        public void Print()
        {
            Console.WriteLine("her name is shikha");
        }
    }
    class multlevel
    {
        static void Main(string[] args)
        {
            Sister s = new Sister();
                s.show();
            s.display();
            s.Print();
        }
    }
    ///// hirarchcal 1
    class Country1
    {
        public void show()
        {
            Console.WriteLine("India is our country ");
        }
    }
    class State0:Country1
    {
        public void display()
        {
            Console.WriteLine("1.Mahaartra");
        }
    }
    class State1:Country1
    {
        public void Print()
        {
            Console.WriteLine("2.Gujrat");
         }
    }
    class State2:Country1
    {
        public void Prnt()
        {
            Console.WriteLine("3.Rajstan");
        }
    }
    class Hirarmethod
    {
        static void Main(string[] args)
        {
            Country c = new Country();
            c.show();
            State0 a = new State0();
            a.display();
            State1 t = new State1();
            t.Print();
            State2 s = new State2();
            s.Prnt();
        }
    }
    ///// hirarchy 2 ex
    class Additonhir 
    {
        int a = 2;int b = 4;
        public void show()
        {
            Console.WriteLine("Addton s  "+(a+b));
        }
    }
    class Subthir : Additonhir
    {
        float c = 3.4f;float d = 3.6f;
        public void display()
        {
            Console.WriteLine("sub s"+(d-c));
        }
    }
    class multhir : Additonhir
    {
        int m = 4;int g = 5;
        public void Print()
        {
            Console.WriteLine("multlcaton s"+(m*g));
        }
    }
    class Dvhir : Additonhir
    {
        int e = 4;int t = 2;
        public void Prnt()
        {
            Console.WriteLine("dvson s"+(e/t));
        }
    }
    class Hirarmethod2
    {
        static void Main(string[] args)
        {
            Additonhir c = new Additonhir();
            c.show();
            Subthir a = new Subthir();
            a.display();
            multhir t = new multhir();
            t.Print();
            Dvhir s = new Dvhir();
            s.Prnt();
        }
    }
}
 
