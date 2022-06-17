using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.loops
{/// <summary>
/// /1234
/// 123
/// 12
/// 1
/// </summary>
    class pattrens
    {
        static void Main(string[] args)
        {
            int max = 4;
            int count = max+1;
            for(int i= 1;i<=max;i++)
            {
                for(int j = 1;j<=max;j++)
                {
                    if (j >= count)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(j);
                    }
                   
                    
                }
                count--;
                Console.WriteLine();
            }
        }
    }
    /////// 1234
    ///     234
    ///      34
    ///       4
    class pattrens1to4
    {
        static void Main(string[] args)
        {
           
            for (int i =1; i <= 4; i++)
            {
                for (int j = i; j <= 4; j++)
                {
                    
                    Console.Write(j);

                }
                
                  Console.WriteLine();
            }
        }
    }
    ///4321
    ///432
    ///43
    ///4
    class pattrens4to1
    {
        static void Main(string[] args)
        {
            int max = 4;
            int count = 1;
            for (int i = 1; i <= max; i++)
            {
                for (int j = max; j >= i; j--)
                {
                    if (j >= count)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                count++;
                Console.WriteLine();
            }
        }
    }
    ////// 12345
    ///     234
    ///      3
    class myprac
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 5;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                   
                    if ((j !< min || j !> max) )
                    {
                        Console.Write(" ");
                    }else
                    {
                        Console.Write(j);
                    }
                }
                min++;
                max--;
                Console.WriteLine();
            }
        }
    }
    ////1
    ///10
    ///101
    ///1010
    ///10101
    class oepattern
    {
        static void Main(string[] args)
        {
            int max = 4;
            int count = max + 1;
            for (int i = 1; i <= max; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                count--;
                Console.WriteLine();
            }
        }
    }
    //////cros with +
    class crosswithplus
    {
        static void Main(string[] args)
        {
            int m;
            int min = 1;
            int max = 7;

            for (int i = 1; i <= max; i++)
            {
                
                for (int j = 1; j <= max; j++)
                {
                    if ((j== min || j== max)&& (i == min || i == max))
                    {
                        Console.Write(" ");
                    }
                    else if ((j == ((max / 2) + 1)) || (i == ((max / 2) + 1)))
                    {
                        Console.Write("*");
                    } 
                    else
                    {
                        Console.Write("+");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    ///////1
    ///   AB
    ///   123
    ///   ABCD
    class digitletterpattern
    {
        static void Main(string[] args)
        {

            int c = 64;
            int max = 7;
            for (int i = 1; i <= max; i++)
            {
                if (i % 2 != 0)
                {

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                }
                else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write((char)(c+j));
                    }
                }

                Console.WriteLine(" ");
            }
            
        }
    }
    ///////*o*o*o
    ///    o*o*o*
    ///    *o*o*o
    class popit
    {
        static void Main(string[] args)
        {
            int max = 6;
            for (int i = 1; i <= max; i++)
            {
                for (int j = 1; j <= max; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("o");
                    }
                }
                
                Console.WriteLine();
            }
        }
    }
}
