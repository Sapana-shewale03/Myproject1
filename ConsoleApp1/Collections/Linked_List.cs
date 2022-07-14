using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Collections
{
    class Linked_List
    {
        static void Main(string[] args)
        {

        LinkedList<string> ll = new LinkedList<string>();
            ll.AddLast("om");
            ll.AddLast("amu");
            ll.AddFirst("meera");
            //Console.WriteLine(ll[0]);
            //ll.Count();
            foreach(string data in ll)
                Console.WriteLine(data);

            LinkedList<int> lll = new LinkedList<int>();
            lll.AddLast(100);
            lll.AddLast(200);
            lll.AddLast(300);
            lll.AddLast(400);
            lll.AddLast(400);
            lll.AddLast(200);
            LinkedListNode<int> nn = lll.Find(200);
            lll.AddBefore(nn, 1000);
            lll.AddAfter(nn, 2000);
            //lll.Clear();
            Console.WriteLine();
            Console.WriteLine("count  "+lll.Count);
            Console.WriteLine(lll.Contains(34));
            LinkedListNode<int> x = lll.First;
            Console.WriteLine("first occurance "+x.Value);
            LinkedListNode<int> y = lll.Last;
            Console.WriteLine("last occurance " + y.Value);
            lll.Remove(400);
            foreach(int d in lll)
                Console.WriteLine(d);


        }
    }
}
