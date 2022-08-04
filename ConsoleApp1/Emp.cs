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
        public Emp(int Eid, string Ename)
        {
            this.eid = Eid;
            this.ename = Ename;

        }

        public override string ToString()
        {
            return "emp id  :" + eid+" emp name "+ename;
        }
        public int Eid  { get => eid; set => eid = value; }
        public string Ename { get => ename; set => ename = value; }

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


