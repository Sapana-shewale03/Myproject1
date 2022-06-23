using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.ArrayDemo
{
    class AvgTDArray
    {
        static void Main(string[] args)
        {

            int[,] a = { { 2, 3, 4 }, { 6, 7, 8 }, { 1, 5, 7 } };
             int avg = 1;int i; int sum = 0;
            int n = a.Length;
            for (i =0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    sum = sum + a[i, j]; 
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            avg = sum / n;
            Console.Write("avg of array is " + avg); Console.WriteLine();
        }
    }
    /////coloum wise sum
    class ColSum
    {
        static void Main(string[] args)
        {
            int[,] a = { { 2, 3, 4 }, { 6, 7, 8 }, { 1, 5, 7 } };
            int i;
            for (i = 0; i < a.GetLength(0); ++i)
            {
               int sum = 0;
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    sum = sum + a[j, i];
                    Console.Write(a[i, j] + " ");
                }
                Console.Write(sum);
                Console.WriteLine();

            }
        }
    }
    /////addition of two matrices
    class AddiArray
    {
        static void Main(string[] args)
        {
            int[,] a = { { 2, 3, 4 }, { 6, 7, 8 }, { 1, 5, 7 } };
            int i;int sum = 0;
            for (i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    sum = sum + a[i, j];
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("sum of matrices is :" + sum);
            Console.WriteLine();
        }
    }
    /////2D array  and display pattern
    /* 1     4
     * 5 6   8
     * 3   7 1 
     * 2      8
     */
   class NumberPattern
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 3, 4,4 }, { 5,6, 7, 8 }, { 3,1, 7, 1 },{ 2,4,5,8} };
            int i; 
            for (i = 0; i < a.GetUpperBound(0)+1; ++i)
            {
                for (int j = 0; j < a.GetUpperBound(1)+1; ++j)
                {
                    if (i == j || j == 0 ||j==a.GetUpperBound(1))
                    {
                        Console.Write(a[i, j]+" ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                 }
                Console.WriteLine();
            }

        }
    }
    ///// star N Pattern
    class StarArrayPatern
    {
        static void Main(string[] args)
        {
            char[,] a = new char[2, 2];
            for(int i=0;i<a.Length;i++)
            {
               for(int j=0;j<a.Length;j++)
                {
                    if (i == j||j==0||j==3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    ///// x pattern
    class XNumberPattren
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 3, 4, 4 }, { 5, 6, 7, 8 }, { 3, 1, 7, 1 }, { 2, 4, 5, 8 } };
            int i;
            for (i = 0; i < a.GetUpperBound(0) + 1; ++i)
            {
                for (int j = 0; j < a.GetUpperBound(1) + 1; ++j)
                {
                    if (i==a.GetUpperBound(0)||j==a.GetUpperBound(1)||i==0||j==0)
                    {
                        Console.Write(a[i, j] + " ");

                    }
                    else
                    {
                        Console.Write("  ");

                    }
                }
                Console.WriteLine();
            }

        }
    }
}
    

