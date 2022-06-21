using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.ArrayDemo
{
    class MergeArray
    {
        static void Main(string[] args)
        {

        int[] a = { 2, 4, 6, 7, 2, 9 };
        int[] b = { 12, 23, 56, 76, 95 };
        int[] c = new int[a.Length + b.Length];
        int j = 0;
            int count1 = 6;
            int[] final = new int[20];
            int s = 0;
            for (int i=0;i<a.Length;i++)
            {
                c[j] = a[i];
                j++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                c[j] = b[i];
                j++;
            }
            Console.WriteLine("***********");
            for (int i = 0; i < c.Length; i++)
            {
                int count = 1;

                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (c[i] == c[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int g = i + 1; g < c.Length;g++)
                    {
                        if (c[i] == c[g])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        final[s] = c[i];
                        s++;
                    }
                }
            }
            Console.WriteLine("***********");
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine(final[i]);
            }
        }
        

    }
}
