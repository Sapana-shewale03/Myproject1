using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp
{
    class Queue_demo
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(100);
            q.Enqueue(200);
            q.Enqueue(300);
            q.Enqueue(400);

           // int remove = q.Dequeue();
            //q.Clear();
           // q.CopyTo();
            foreach(int d in q)
                Console.WriteLine(d);
        }
    }
}
