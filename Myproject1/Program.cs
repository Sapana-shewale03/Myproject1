using System;

namespace Myproject1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 34, 2, 6, 4 };
            int[] result = {0,0,0,0,0,0};
            int[] countarr = { 0,0,0,0,0,0};
            Console.WriteLine(string.Join(" ", a));
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                for (int j=i+1;j<a.Length;j++)
                {
                    
                    if(a[i]==a[j])
                    {
                        count++;
                    }
                     
                }
                result[i] = a[i];
                countarr[i] = count;

                Console.WriteLine("fre of "+a[i]+ " is "+count);
            }
        }
    }
}
