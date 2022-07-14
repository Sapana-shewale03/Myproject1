using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1
{
    class Exceptionhandling
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            Console.WriteLine("enter  number");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("division "+a/b);
                Console.WriteLine("try ends");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("1");
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("2");
                Console.WriteLine(e.Message);
            }
            catch(SystemException e)//universal exception handler it should be last in all catch stmt
            {
                Console.WriteLine(e.Message);
            }
            for(int i=1;i<=10;i=i+2)
            {
                Console.WriteLine(i);
            }
        }
    }
    //// null ecepction
    class NULLExceptionhandling
    {
        static string nm;
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            Console.WriteLine("enter  number");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("division " + a / b);
                try
                {
                    Console.WriteLine(" enter age");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch(NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("1");
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("2");
                Console.WriteLine(e.Message);
            }
            catch (SystemException e)//universal exception handler it should be last in all catch stmt
            {
                Console.WriteLine(e.Message);
            }
            for (int i = 1; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
