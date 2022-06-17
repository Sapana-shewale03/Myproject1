using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.loops
{
 /* *
   **
  ***
 ****  */
    class patterns
    {
        static void Main(string[] args)
        {
            int m;
            for(int i= 1;i<=4;i++)
            {
                m = 5-i;
                while (m > 0)
                {
                    Console.Write(" ");
                    m--;
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    //// code for 1 to 5 table
    class table1to5
    {
        static void Main(string[] args)
        {
            int tb = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    tb = i * j;
                    Console.WriteLine(+i+"x"+j+"="+tb);
                }
                Console.WriteLine();
            }
        }
    }

    /*  ********
       *       *
       *       *
       *       *
       *********   */
    class sqpatterns
    {
        static void Main(string[] args)
        {
            int m;
            int min = 1;
            int max = 4;

            for (int i = 1; i <= max; i++)
            {
                
                for (int j = 1; j <= max; j++)
                {
                    if ((i == min&& i == max) && (j == min && j== max))
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(" *");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    /////// hollow triangle
    class holllowytriangle
    {
        static void Main(string[] args)
        {
            int m;
            int min = 1;
            int max = 4;

            for (int i = 1; i <= max; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    if ((i == (max - 1)) && (j == (max - 2)))
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(" *");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    ////// n type star
    class ntypestars
    {
        static void Main(string[] args)
        {
            int m;
            int min = 1;
            int max = 6;

            for (int i = 1; i <= max; i++)
            {

                for (int j = 1; j <=max; j++)
                {
                    if ((j==min || j==max) ||(i==j))
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
               Console.WriteLine(" ");
            }
        }
    }
    ///// + cross type star pattern
    class crosstypestars
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
                    if ((j == ((max/2)+1)) || (i == ((max/2)+1)))
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine(" ");
            }
        }
    }
}
