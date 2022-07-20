using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp
{
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
            //  Deptempcont d = new Deptempcont(1, "Diksha");
            Emp em = new Emp(1, "Disha");
            Console.Write(em.eid + "emp name:" + em.ename);

        }
    }
    class customfordict
    {
        string m;
        public customfordict(string M)
        {
            this.m =M;
        }
        public override string ToString()
        {
            return "emp id  :" + m;
        }
        public string M { get => m; set => m = value; }
      
    }
}


