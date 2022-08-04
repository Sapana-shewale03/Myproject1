using System;
using System.Collections.Generic;
using System.Text;

namespace Advancecsharp.Collections
{
    class Dec_of_collection
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
            lst.Add(500);
            lst.Add(300);
            lst.Add(300);
            lst.Add(300);

           lst.Remove(300);

            lst.RemoveAll(item => item == 300);
            // lst.RemoveAt(2);
            //  lst.RemoveRange(1,3);
           // lst.Reverse();
            lst[0] = 1000;
            lst.IndexOf(2,3000);
            Console.WriteLine(lst.Count);
            Console.WriteLine(lst.Capacity);
            for (int j = 0; j < lst.Count; j++)
            {
                Console.WriteLine(lst[j]);
            }
            Console.WriteLine("***************");
            foreach(int data in lst)
                Console.WriteLine(data);

            //lst.Clear();
            Console.WriteLine(lst.Contains(90));
            int i = lst.IndexOf(309);
           // lst.InsertRange();
            string s = "sanaya";
            s.IndexOf('a');
            s.LastIndexOf('a');

            List<int> lst2 = new List<int>() { 111, 112, 113 };
            lst2.AddRange(lst);
            lst2.InsertRange(1, lst);
            for(int k =0;k<lst2.Count;k++)
                Console.Write(lst2[k]+" ");
        }
    }
}
