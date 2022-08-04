using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp.Delegate
{
    class multicating_delegate
    {
        public delegate void rectabgledel(double h, double w);
        public void aarea(double h,double w)
        {
            Console.WriteLine(w*h);
        }
        public void perimeter(double h, double w)
        {
            Console.WriteLine(2*(w + h));
        }
        static void Main(string[] args)
        {
            multicating_delegate md = new multicating_delegate();
            rectabgledel rd = new rectabgledel(md.aarea);
            rd = rd + md.perimeter;
            rd.Invoke(6.3, 4.5);
            rd.Invoke(4.3, 6.7);
        }
    }
}
