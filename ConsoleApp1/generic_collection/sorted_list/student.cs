using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp.sorted_list
{
    class stud:IComparable<stud>
    {
        string sname;
        long mob;
        int per;
        public stud(string Sname,long Mob,int Per)
        {
            this.Sname = Sname;
            this.Mob = Mob;
            this.Per = Per;
        }
        public int CompareTo(stud other)
        {
            return this.per.CompareTo(other.per);
        }
        public override string ToString()
        {
            return "student name "+Sname+" student contact no "+Mob+" students percentage "+Per;
        }
        public string Sname { get => sname; set => sname = value; }
        public long Mob { get => mob; set => mob = value; }
        public int Per { get => per; set => per = value; }
    }
    class student
    {
        static void Main(string[] args)
        {
            SortedList<stud, string> sm = new SortedList<stud, string>();
            sm.Add(new stud("ram", 9087654679, 98), "BA");
            sm.Add(new stud("shyam", 9082454679, 99), "MA");
            sm.Add(new stud("gyan", 9087654567, 93), "CA");
            sm.Add(new stud("deva", 9082345679, 92), "Art");
            foreach(KeyValuePair<stud,string>kv in sm)
                Console.WriteLine(kv.Key+"==>"+kv.Value);

        }
    }
    // emp ss
     class Employee: IComparable<Employee>
    {
        int eid;
        string name;
        public Employee(int Eid,string ename)
        {
            this.Eid = Eid;
            this.Name = ename;
        }
        public int CompareTo(Employee other)
        {
            if (this.eid == other.eid)
                return this.name.CompareTo(other.name);
            else
            {
                return this.eid.CompareTo(other.eid);
            }
        }

        public override string ToString()
        {
            return "emp name "+Eid+" name "+Name;
        }
        public int Eid { get => eid; set => eid = value; }
        public string Name { get => name; set => name = value; }
    }
    class Empss
    {
        static void Main(string[] args)
        {
            SortedList<Employee,string> ss = new SortedList<Employee,string>();
            ss.Add(new Employee(5, "wam"), "deva");
            ss.Add(new Employee(5, "shyam"), "tadha");
            ss.Add(new Employee(7, "vyam"), "shrey");
            foreach(KeyValuePair<Employee, string> kv in ss)
                Console.WriteLine(kv.Key + "==>" + kv.Value);

        }
    }
}
