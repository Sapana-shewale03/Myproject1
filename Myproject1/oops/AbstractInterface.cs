using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.oops
{
        public interface IPtable
         {
           void decl(int n);
          }
    abstract class Abstr
    {
        public abstract void decla(int m);
    }
    class Additionofabst : Abstr,IPtable
    {
        public void decl(int n)
        {
            Console.WriteLine("interface class");
        }
        public override void decla(int m)
        {
            Console.WriteLine("absract class");
        }
        public void show(int n, int m)
        {
            Console.WriteLine("addition of interface and absract class is : " + (n + m));
        }
    }

        class Demointandabsr
        {
            static void Main(string[] args)
            {
                Additionofabst a = new Additionofabst();
                a.show(12,23);
            }
        }
    /////////
   abstract class MathAbst
    {
        public abstract void negat(int n);
    }
   class NegativeAbst:MathAbst
    {
        public override void negat(int n)
        {
            int m = (-(n));
            Console.WriteLine("positive to negative nu: "+m);
        }
    }
 
        class SqAbstr:MathAbst
    {
        public override  void negat(int n)
        {
            int sq = n * n;
            Console.WriteLine("multiplication is : "+sq);
        }
    }
    class AbHirarchical
    {
        static void Main(string[] args)
        {
          SqAbstr  s = new SqAbstr();
            s.negat(3);
            NegativeAbst n = new NegativeAbst();
            n.negat(5);
        }
    }
}
    

