using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp
{
    /// <summary>
    /// /1st prg
    /// </summary>
    class Test1
    {
        static void Main(string[] args)
        {
            LinkedList<string> lll = new LinkedList<string>();
            lll.AddLast("shivay");
            lll.AddLast("namah");
            lll.AddLast("shivay");
            lll.AddLast("om");
            lll.AddFirst("jai");
            lll.AddLast("shankara");
            LinkedListNode<string> nn = lll.Find("shivay");
            lll.AddBefore(nn, "deva");
            lll.AddAfter(nn, "ishwara");
            Console.WriteLine();
          lll.Remove("shivay");
            foreach (string d in lll)
                Console.WriteLine(d);
        }
    }
    //2nd prg 
    class list_color
    {
        static void Main(string[] args)
        {
            List<string> color = new List<string>() { "yellow", "green", "pink", "yellow" };
            
            foreach (string c in color)
                Console.WriteLine(c);
        }
    }
    /////3rd prg
    class ListSwap
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() {2,6 };
            
            for(int i=0;i<a.Count;i++)
            {
                for(int j=i+1;j<a.Count;j++)
                {
                    int temp = a[j];
                    a[j] = a[i];
                    a[i] = temp;
                }
            }
            foreach(int c in a)
                Console.WriteLine(c);
        }
    }
    /////4 prg
    class secondele_replace
    {
        static void Main(string[] args)
        {
            LinkedList<int> a = new LinkedList<int>();
            a.AddLast(1);
            a.AddLast(7);
            a.AddLast(3);
            a.AddLast(4);
            LinkedListNode<int> nn = a.Find(7);
            a.AddBefore(nn, 2);
            foreach (int c in a)
                Console.WriteLine(c);
        }
    }
    ///5 prg
    class student_list
    {
        static void Main(string[] args)
        {
            List<string> s = new List<string>() { "ram", "shyam", "shivay", "deva" };
            foreach(string c in s)
                Console.WriteLine(c);
        }
    }
    ////6.prg convert list into array
    class list_array
    {
        static void Main(string[] args)
        {
            LinkedList<int> a = new LinkedList<int>() ;
            a.AddLast(8);
            a.AddLast(1);
            a.AddLast(3);
            a.AddLast(4);
            int[] arr = new int[a.Count];
            a.CopyTo(arr, 0);

            foreach (int m in arr)
                Console.WriteLine(m);
        }
    }
    ////7.reverse order
    class reverse_list
    {
        static void Main(string[] args)
        {
            List<int> r = new List<int>() { 2,3,5,6,7,4};
           
            int rev=0;
            
               int j = r.Count - 1;
                for (int i = 0; i < r.Count / 2; i++)
                {
                    int temp = r[i];
                    r[i] = r[j];
                    r[j] = temp;
                    j--;
                }
            
            foreach (int c in r)
                Console.WriteLine(c);
        }
    }
    ////8. string sorting
    class sortliststring
    {
        static void Main(string[] args)
        {
            List<string> s = new List<string>() { "c#", "java", "python", "c++", "c lang" };
            string temp;
            for (int i = 0; i < s.Count; i++)
            {
                for (int j = i+1; j < s.Count; j++)
                {
                    if (s[i].CompareTo(s[j]) == 1)
                    {
                        temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
            }
            foreach(string m in s)
                Console.WriteLine(m);
        }
    }
    ///9.emp class
    class Empl
    {
        string ename;
        string des;
        int age;
        public Empl(string Ename, string Des, int Age)
        {
            this.ename = Ename;
            this.des = Des;
            this.age = Age;
        }
        public override string ToString()
        {
            return "emp name " + ename + " designasation "+des+" age of emp "+age;
        }
        public string Ename { get => ename; set => ename = value; }
        public string Des { get => des; set => des = value; }
        public int Age { get => age; set => age = value; }
    }
    class Emplist
        {
            static void Main(string[] args)
            {
                List<Empl> ll = new List<Empl>();
                ll.Add(new Empl("Deepa", "manager", 35));
                ll.Add(new Empl("sapna", "tech lead", 34));
                ll.Add(new Empl("xyz", "tech lead", 30));
            ll.Add(new Empl("diksha", "developer", 28));
                ll.Add(new Empl("prati", "HR", 37));
                Empl temp ;
            
            //ll.Sort(Empl.Age);
             for(int i=0;i<ll.Count;i++)
                {
                    for(int j=i+1;j<ll.Count-1;j++)
                    {
                        if (ll[i].Age > ll[j].Age)
                        {
                            temp = ll[i];
                            ll[i] = ll[j];
                            ll[j] = temp;
                        }
                    }
                }
            
            foreach(Empl n in ll)
            Console.WriteLine(n);


        }
    }
        ////10.dictonary
        class dictinary
        {
            static void Main(string[] args)
            {
                Dictionary<int, string> d = new Dictionary<int, string>();
                d.Add(1, "suma");
                d.Add(2, "reva");
                d.Add(3, "shreya");
                d.Add(4, "feren");
                foreach (KeyValuePair<int, string> k in d)
                    Console.WriteLine(k.Key + "=>" + k.Value);

            }
        }
        ////11.get keys from dictionary
        class getkeysdictinary
        {
            static void Main(string[] args)
            {
                Dictionary<int, string> d = new Dictionary<int, string>();
                d.Add(1, "suma");
                d.Add(2, "reva");
                d.Add(3, "shreya");
                d.Add(4, "feren");
                foreach (KeyValuePair<int, string> k in d)
                    Console.WriteLine(k.Key);

            }
        }
        ////12.only values
        class getvaluedict
        {
            static void Main(string[] args)
            {
                Dictionary<int, string> d = new Dictionary<int, string>();
                d.Add(1, "suma");
                d.Add(2, "reva");
                d.Add(3, "shreya");
                d.Add(4, "feren");
                foreach (KeyValuePair<int, string> k in d)
                    Console.WriteLine(k.Value);

            }
        }
        ////13.custom class as key and any other object as value
        class customclassdict
        {
            static void Main(string[] args)
            {
                Dictionary<customfordict, string> d = new Dictionary<customfordict, string>();
                d.Add(new customfordict("A"), "same");
                d.Add(new customfordict("B"), "duplicate");
                d.Add(new customfordict("C"), "equal");


                foreach (KeyValuePair<customfordict, string> k in d)
                    Console.WriteLine(k.Key + "=>" + k.Value);

            }
        }
        /////14.queue add 5 and remove first 2
        class queuetest
        {
            static void Main(string[] args)
            {
                Queue<string> q = new Queue<string>();
                q.Enqueue("A");
                q.Enqueue("B");
                q.Enqueue("C");
                q.Enqueue("D");
                q.Enqueue("E");

                string remove = q.Dequeue();
                string remove1 = q.Dequeue();

                //q.Clear();
                // q.CopyTo();
                foreach (string d in q)
                    Console.WriteLine(d);
            }
        }
        ////15.stack show push ,od,pop,peek
        class Stacktest
        {
            static void Main(string[] args)
            {

                Stack<int> st = new Stack<int>();
                st.Push(1);
                st.Push(2);
                st.Push(3);
                st.Push(4);
                st.Push(5);
                st.Push(6);

                st.Pop();
                int m = st.Peek();
                Console.WriteLine("peek element is " + m);

                foreach (int d in st)
                    Console.WriteLine(d);

            }
        }
        ////16.emp(int eno,string name , string dep)
        class Emplinked
        {
            int eid;
            string ename;
            string dep;
            public Emplinked(int Eid, string ename1, string dep1)
            {
                this.eid =  Eid;
                this.ename = ename1;
                this.dep = dep1;

            }
            public override string ToString()
            {
                return "emp id : " + eid + " , name : " + ename + " , detpt : " + dep;
            }
            public int Eid { get => eid; set => eid = value; }
            public string ename1 { get => ename; set => ename = value; }
            public string dep1 { get => dep; set => dep = value; }

        }
        class Tenemp
        {
            static void Main(string[] args)
            {
                LinkedList<Emplinked> e = new LinkedList<Emplinked>();
                e.AddLast(new Emplinked(1, "raj", "math"));
                e.AddLast(new Emplinked(2, "rom", "sci"));
                e.AddLast(new Emplinked(4, "bhog", "eng"));
                e.AddLast(new Emplinked(5, "shyam", "electric"));
                e.AddLast(new Emplinked(6, "som", "math"));
                e.AddLast(new Emplinked(8, "ram", "sci"));
                e.AddLast(new Emplinked(10, "rutu", "math"));
                string dname = "";
                foreach (Emplinked m in e)
                {
                    if (m.Eid == 10)
                    {
                        dname = m.dep1;
                        break;
                    }
                }
                foreach (Emplinked m in e)
                {
                    if (m.dep1 == dname)
                    {
                        Console.WriteLine(m);
                    }
                }
            
        }
        }
        //////17.use multiple catch block
        class exception_mul_catch
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter 2 values");
                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(a / b);
                }
                catch (ArithmeticException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        ////18.custom exception show use of throw keyword
        public class NoSameNumberException : Exception
        {
            public override string Message
            {
                get
                {
                    return "both numbers can not be same";
                }
            }
        }
        class Throwexception
        {
            static void Main(string[] args)
            {
                int x, y, z;
                Console.WriteLine("ENTER TWO INTEGER NUMBERS:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                try
                {
                    if (x == y)
                    {
                        throw new NoSameNumberException();
                    }
                    z = x / y;
                    Console.WriteLine(z);
                }
                catch (NoSameNumberException one)
                {
                    Console.WriteLine(one.Message);
                }
                Console.WriteLine("End of the program");
                Console.ReadKey();
            }
        }
        
}

