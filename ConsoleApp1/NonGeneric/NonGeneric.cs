using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp
{
    class ss<T>
    {
        private T obj;
        public T Obj { get => obj; set => obj = value; }
     }
        class S
        {
            private object obj;
            public object Obj { get => obj; set => obj = value; }
        }
    class NonGeneric2
    {
            static void Main(string[] args)
            {    
                ss<float> s1 = new ss<float>();
                s1.Obj = 4.5f;
                float d = s1.Obj;

                S s = new S();
                s.Obj = "omkar";
                s.Obj = 90000;

                int x = (int)s.Obj;
            }
    }
}
