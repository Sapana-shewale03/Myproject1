using System;

namespace Myproject1.oops
{
    /// <summary>
    /// /person add prg n propery
    /// </summary>
    class Peradd
    {
        int id;
        string name;
        string addr;
        string city;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Addr
        {
            get { return addr; }
            set { addr = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        void display()
        {
            Console.WriteLine("emp id:" + Id + "\nemp name:" + Name + "\nemp addr:" + Addr + "\nemp city" + City);
        }
        static void Main(string[] args)
        {
            Peradd p = new Peradd();
            p.Id = 1;
            p.Name = "Dev";
            p.Addr = "narhe";
            p.City = "pune";
            p.display();
        }
    }
    class AccessMo
    {
        int id;
        string name;
        float perc;
        bool isplace;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Perc
        {
            get { return perc; }
            set { perc = value; }
        }
        public bool Isplace
        {
            get { return isplace; }
            set { isplace = value; }
        }
        void display()
        {
            Console.WriteLine(Id + " " + Name + " " + Perc + " " + Isplace);
        }
        static void Main(string[] args)
        {
            AccessMo a = new AccessMo();
            a.id = 1;
            a.name = "Ram";
            a.perc = 76.76f;
            a.isplace = true;
            a.display();
            AccessMo a1 = new AccessMo();
            a1.id = 2;
            a1.name = "Shyam";
            a1.perc = 47.34f;
            a1.isplace = false;
            a1.display();
        }
    }
    //////contantment for car
    class Carnfo
    {

        int modelno;
        string cname;
        float prize;
        Carnfo(int modelno, string cname, float prize)
        {
            this.modelno = modelno;
            this.cname = cname;
            this.prize = prize;
        }
        class Engine
        {
            string type;
            Engine(string type)
            {
                this.type = type;
            }
            static void Main(string[] args)
            {
                Carnfo c = new Carnfo(1, "xyz", 23.44f);
                Engine e = new Engine("ds");
                Console.Write("model number :" + c.modelno + "\ncar name :" + c.cname + "\ncar prze :" + c.prize + "engne type:" + e.type);
            }
        }
    }


    /////////employee usng propertes
    class EmpProp
    {
        int eid;
        string ename;
        double salary;
        public int eId
        {
            get { return eid; }
            set { eid = value; }
        }
        public string eName
        {
            get { return ename; }
            set { ename = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        void display()
        {
            Console.WriteLine(eId + " " + eName + " " + Salary);
        }
        static void Main(string[] args)
        {
            EmpProp e = new EmpProp();
            e.eid = 1;
            e.ename = "Ram";
            e.salary = 7633.76;
            e.display();
        }
    }
    /////// contanment for dept emp
    class Deptempcont
    {
        public int did;
        public string dname;
        public Deptempcont(int did, string dname)
        {
            this.did = did;
            this.dname = dname;
        }
    }
    class Emp
    {
        int eid;
        string ename;
        public Emp(int eid, string ename)
        {
            this.eid = eid;
            this.ename = ename;
        }

        static void Main(string[] args)
        {
            Deptempcont d = new Deptempcont(1, "Diksha");
            Emp em = new Emp(1, "Disha");
            Console.Write("dept d :" + d.did + "\ndept name :" + d.dname + "\nenp d :" + em.eid + "emp name:" + em.ename);

        }
    }

    /////////////contanment of 2 objects access
    class Bag
    {
        string bcolor;
        string brname;
        int price;
        public Bag(string bcolor, string brname, int price)
        {
            this.bcolor = bcolor;
            this.brname = brname;
            this.price = price;
        }
        public void show()
        {
            Console.WriteLine("bag color:" + bcolor + "\tbrand name:" + brname + "\tprice :" + price);

        }
    }
    class Pen
    {
        string pname;
        string pcolor;
        Bag b;
        public Pen(string pname, string pcolor, Bag b)
        {

            this.pname = pname;
            this.pcolor = pcolor;
            this.b = b;
        }
        public void showPen()
        {
            Console.WriteLine("pen name:" + pname + "pen color:" + pcolor);
            b.show();
        }
    }
    class Nib
    {
        string type;
        Pen p;
        Nib(string type, Pen p)
        {
            this.type = type;
            this.p = p;
        }
        public void showNib()
        {
            Console.WriteLine("Nb type is :" + type);
            p.showPen();
        }
        static void Main(string[] args)
        {
            Nib n = new Nib("Alluminium", new Pen("Cello", "Blue", new Bag("Purple", "Levis", 1200)));
            n.showNib();
        }
    }
 //// car prg usng property
    class carprp
    {
        int modelno;
        string cname;
        int price;
        string cleanupdate;
        public int Modelno
        {
            get { return modelno; }
            set { modelno = value; }
        }
        public string Cname
        {
            get { return cname; }
            set { cname = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Cleanupdate
        {
            get { return cleanupdate; }
            set { cleanupdate = value; }
        }
        public void show()
        {
            Console.WriteLine("model no :"+Modelno+"\n car name"+Cname+"\nprice"+Price+" \ndate:"+Cleanupdate);
        }
    
        static void Main(string[] args)
        {
        carprp c = new carprp();
        c.Modelno = 12;
        c.Cname = "Benz";
        c.Price = 12334;
        c.Cleanupdate = "year";
        c.show();
        }
    }
}
 






