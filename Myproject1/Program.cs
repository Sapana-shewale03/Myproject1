using System;

namespace Myproject1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 34, 5, 6, 4 };
            Console.WriteLine(string.Join(" ", a));
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i; k > 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i] + " " + count);
                    if (count > 1)
                    {
                        Console.WriteLine(a[i] + " " + count);
                    }
                }

            }
        }
    }
}
