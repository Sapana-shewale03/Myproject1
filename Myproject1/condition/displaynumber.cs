using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.basic_prg
{
    class displaynumber
    {
        public static void Main(string[] args)
        {
            int i;
            int j;
            int k;
            //display number between 1 to 5
            Console.WriteLine("number from 1 to 5   ");
            for (i = 1; i < 6; i++)
            {
                Console.WriteLine(+i);
                Console.ReadLine();
            }
            //display number between 15 to 25
            Console.WriteLine("number betweeb 15 to 25    ");
            for (j = 15; j < 25; j++)
            {
                Console.WriteLine(+j);
                Console.ReadLine();
            }

            //display number from 10 to 1
            Console.WriteLine("number betweeb 10 to 1    ");
            for (k = 10; k > 0; k--)
            {
                Console.WriteLine(+k);
                Console.ReadLine();
            }
        }
    }
}
