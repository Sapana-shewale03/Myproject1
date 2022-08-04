using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancecsharp.Delegate
{
    public delegate void mydel1(int a, int b);
    class Annomous_fun
    {
        static void Main(string[] args)
        {
            mydel1 d = delegate (int a, int b)
            {
                Console.WriteLine("profductis : " + (a * b));
            };
            d(8, 4);
        }
    }
    //// class lambda
    class lambda1
    {
        static void Main(string[] args)
        {
            mydel1 d = (a, b) =>
            {
                Console.WriteLine("profductis : " + (a * b));
            };
            //or for only line if we have morethan 1 line we can give brackets
            // mydel1 d = (a,b)=> Console.WriteLine("profductis : " + (a * b));

            d(7, 4);
        }
    }
    ///lambda 2 ex
    public delegate int mydel2(int a);
    class lambda2
    {
        public static int sq(int a)
        {
            return a * a;
        }
        static void Main(string[] args)
        {
            //1type or as 2 mydel1 d = (a, b) =>Console.WriteLine("profductis : " + (a * b));
            //or for only line if we have morethan 1 line we can give brackets
            //2
            mydel2 d = (a) => a * a;
            int sqa = d(7);
            Console.WriteLine("sq is " + sqa);
        }
    }
    ///lambda factorial function
    public delegate int factorial(int a);
    class lambdafact
    {
        static void Main(string[] args)
        {
            factorial m = (a) =>
              {
                  int f = 1;
                  for (int i = 1; i <= a; i++)
                  {
                      f = f * i;
                  }
                  return f;
              };
            int fct = m(5);
            Console.WriteLine(fct);
        }
    }
    //////func , action and predicate delegates use
    class useofdelegte
    {
        static void sum(int a, int b)
        {
            Console.WriteLine("sum is " + (a + b));
        }
        static void message(string msg)
        {
            Console.WriteLine("message is " + msg);
        }
        static bool evenno(int a)
        {
            return a % 2 == 0;
        }
        static double area(float r)
        {
            return (r * r * 3.17);
        }
        static int cube(int a)
        {
            return (a * a);
        }
        static void Main(string[] args)
        {
            Action<int, int> d1 = sum;
            d1(2, 4);
            Action<string> d2 = message;
            d2("good morning");
            Predicate<int> d3 = evenno;
            d3(4);
            Func<float,double> d4 = area;
            d4(3.4f);
            Func<int,int> d5 = cube;
            d5(5);

        }

    }
}

