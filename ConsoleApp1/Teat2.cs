using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp
{
    class Teat2
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int count2 = 0, count1 = 0, count3 = 0;
            while (a > 0)
            {
                int r = a % 10;
                if (r % 2 == 0)
                {
                    count2++;
                }
                else
                {
                    count3++;
                }
                a = a / 10;
                count1++;
            }
            if (count1 == count2)
            {
                Console.WriteLine("Not Happy");
            }
            else if (count1 == count3)
            {
                Console.WriteLine("Happy");
            }
            else
            {
                Console.WriteLine("not happy");
            }
        }
    }
    //1.sort list of string type
    class sortlist
    {
        static void Main(string[] args)
        {
            List<string> s = new List<string> { "rama", "sita", "shreya", "aanu" };
            s.Sort();
            foreach (string a in s)
                Console.WriteLine(a);
        }
    }
    ///2.WAP to create a class Employee with (name, designation ,salary).Now create and add Employee objects
    ///elements to List. Print List.
    class emp
    {
        string ename;
        string des;
        int salary;
        public  emp(string Ename, string Des, int Salary)
        {
            this.Ename = Ename;
            this.Des = Des;
            this.Salary = Salary;
        }
        public override string ToString()
        {
            return "emp name  :" + ename + " empdesgnation " + des + " salary " + salary;
        }

        public string Ename { get => ename; set => ename = value; }
        public string Des { get => des; set => des = value; }
        public int Salary { get => salary; set => salary = value; }
    }
    class empsalary
    {
        static void Main(string[] args)
        {
            List<emp> le = new List<emp>();
            le.Add(new emp("swaraj", "engg", 234));
            le.Add(new emp("Radha", "lect", 2345));
            le.Add(new emp("Deavsnh", "teacher", 874));
            le.Add(new emp("Geeta", "astro", 8774));
            foreach (emp a in le)
                Console.WriteLine(a);

        }
    }
    // 3	WAP to create a Queue with some colors(String) using generics.
    class QueueTest
    {
        static void Main(string[] args)
        {
            Queue<string> ss = new Queue<string>();
            ss.Enqueue("pink");
            ss.Enqueue("red");
            ss.Enqueue("Green");
            ss.Enqueue("Purple");
            foreach (string n in ss)
                Console.WriteLine(n);
        }
    }
    ///4. 4.	WAP to add user defined objects of type Employee in a HashSet employee object. Make
    ///sure if I create 2 
    ///different objects with same data the other one should not be added as hashset stores unique objects.
    class emp1
    {
        string ename;

        public emp1(string Ename)
        {
            this.Ename = Ename;

        }
        public override string ToString()
        {
            return "emp name  :" + ename;
        }

        public string Ename { get => ename; set => ename = value; }

    }
    class hashemp
    {
        static void Main(string[] args)
        {
            HashSet<emp1> hs = new HashSet<emp1>();
            HashSet<emp1> hs1 = new HashSet<emp1>();
            hs.Add(new emp1("ram"));
            hs.Add(new emp1("sita"));
            hs.Add(new emp1("shyam"));
            hs1.Add(new emp1("ram"));
            hs1.Add(new emp1("deva"));
            hs1.Add(new emp1("shivay"));
            hs1.IntersectWith(hs);
            foreach (emp1 b in hs1)
                Console.WriteLine(b);
        }
    }
    /////5.	WAP to create SortedList where key is of Integer type and value string and print all key-value pairs.
    class sortelisttype
    {
        static void Main(string[] args)
        {
            SortedList<int, string> ss = new SortedList<int, string>();
            ss.Add(2, "xyz");
            ss.Add(4, "abc");
            ss.Add(3, "pqr");
            foreach (KeyValuePair<int, string> k in ss)
                Console.WriteLine(k.Key + "==>" + k.Value);
        }
    }
    ////6.6.	WAP to create Dictionary where key is of string type and value of float type and
    ///print all key-value pairs.
    class dictdisplay
    {
        static void Main(string[] args)
        {
            Dictionary<string, float> sf = new Dictionary<string, float>();
            sf.Add("xyz", 3.4f);
            sf.Add("abc", 5.4f);
            sf.Add("pqr", 8.5f);
            foreach (KeyValuePair<string, float> k in sf)
                Console.WriteLine(k.Key + "==>" + k.Value);
        }
    }
    ////7.Make use of such collection that stores moviename such that last entered movie is first
    //deleted and accordingly previous one.
    class collectionaslifo
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("ddlj");
            s.Push("yjhd");
            s.Push("kkkg");
            s.Pop();
            foreach (string j in s)
                Console.WriteLine(j);
        }
    }
    ///8.	WAP to create SortedList<Employee,string> where key is of Employee type and value 
    ///is departmentname(string) he works in. SortedList should maintain data in descending order 
    //  of salary.
    class emp2 : IComparable<emp2>
    {
        string ename;
        long sal;

        public emp2(string Ename, long Sal)
        {
            this.Ename = Ename;
            this.sal = Sal;
        }
        public int CompareTo(emp2 other)
        {
            return other.Sal.CompareTo(this.Sal);
        }
        public override string ToString()
        {
            return "emp name  :" + ename + "salary  " + sal;
        }

        public string Ename { get => ename; set => ename = value; }
        public long Sal { get => sal; set => sal = value; }

    }
    class empsortedlist
    {
        static void Main(string[] args)
        {
            SortedList<emp2, string> s = new SortedList<emp2, string>();
            s.Add(new emp2("shlok", 3623783), "comp");
            s.Add(new emp2("Aarya", 38483), "math");
            s.Add(new emp2("Devansh", 8473874), "sci");
            s.Add(new emp2("Devki", 7484), "elect");
            foreach (KeyValuePair<emp2, string> k in s)
                Console.WriteLine(k.Key + "==>" + k.Value);
        }
    }
    ///9.	 Create a class Flat (flatno,WingName,List<Member> memberlist)
    // Member(memberid, membername, profession, age)
    //Create of 2 flat objects
    class Member
    {
        public int np;//number of person
        public string name;
        public string gender;
        public Member(int Np, string Name, string Gender)
        {
            this.np = Np;
            this.name = Name;
            this.gender = Gender;
        }
        static void Main(string[] args)
        {
            Member a = new Member(3, "father", "male");
        }
    }
    class flat
    {
        public int fno;
        public string wingname;
        public List<Member> mlist;
        public flat(int Fno, string Wingname, List<Member> mlist)
        {
            this.fno = Fno;
            this.wingname = Wingname;
            this.mlist = mlist;
        }
        void show()
        {
            Console.WriteLine("flat no: " + fno + "wing name  " + wingname + " " + "member " + mlist);
        }
        static void Main(string[] args)
        {

            List<Member> family = new List<Member>();
            family.Add(new Member(2, "mother", "female"));
            family.Add(new Member(1, "Son", "male"));
            flat f = new flat(204, "D", family);
            f.show();
            foreach (Member m in family)
            {
                Console.Write("flat no: " + m.np);
                Console.Write(" *name :" + m.name);
                Console.WriteLine("  *gender: " + m.gender);

            }
        }
    }
    ////or for 9
    class familyflat
    {
        static void Main(string[] args)
        {
            List<flat> f = new List<flat>();
            do
            {
                Console.WriteLine("enetr flat no and wing");
                int fn = Convert.ToInt32(Console.ReadLine());
                string wing = Console.ReadLine();
                Console.WriteLine("enter no of memnbers in your flat");
                int n = int.Parse(Console.ReadLine());
                List<Member> ml = new List<Member>();

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("enter member count relation and gender");
                    int mnm = int.Parse(Console.ReadLine());
                    string r = Console.ReadLine();
                    string g = Console.ReadLine();
                    Member m = new Member(mnm, r, g);
                    ml.Add(m);
                }
                f.Add(new flat(fn, wing, ml));
                Console.WriteLine("do you want add one more flat detail");
                string ch = Console.ReadLine();
                if (ch.ToLower() == "no")
                    break;
            } while (true);
            foreach (flat fn in f)
            {
                Console.WriteLine("flat no " + fn.fno);
                Console.WriteLine("wing " + fn.wingname);
                List<Member> ml1 = fn.mlist;
                foreach (Member ml in ml1)
                    Console.WriteLine(ml);

            }
        }
    }
}