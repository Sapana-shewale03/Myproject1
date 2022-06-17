using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.oops
{
    class InhertanceBasekey
    {
        public int digits = 12;
        public InhertanceBasekey(int x)
        {
            Console.WriteLine(" PARENT CLASS  :"+x);
        }
        public void show()
        {
            Console.WriteLine("SHOW method of parent class");
        }
    }

    class Chld : InhertanceBasekey
    {
        public int digits = 50;
        public Chld():base(45)
        {
            Console.WriteLine(" CHILD CLASS");
        }

        public void show()
        {
            base.show();
            Console.WriteLine(" show method of chils clas  \n"+digits + " " + base.digits);
        }
    }
    class Inhechild
    {
        static void Main(string[] args)
        {
            Chld c = new Chld();
                c.show();
        }
    }
    ////// overrdng real word example in inheritance
   class Country
    {
        public virtual void show()
        {
            Console.WriteLine(" our country is India  ");
        }
    }
    class State:Country
    {
        public override void show()
        {
            Console.WriteLine("India has Maharashtra state");
        }
    }
    class  District:Country
    {
        public void show()
        {
            Console.WriteLine("Maharashtra has Pune district");
        }
    }
    class RealWorld
    {
        static void Main(string[] args)
        {
            Country c = new Country();
            c.show();
            c = new State();
            c.show();
            c=new District();
            c.show();
        }
    }
}
