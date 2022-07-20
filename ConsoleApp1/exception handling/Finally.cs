using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Advancecsharp.exception_handling
{
    class Finally
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;
            try
            {
                Console.WriteLine("enter number");
                int a = int.Parse(Console.ReadLine());
                sr = new StreamReader("D://a.txt");
                Console.WriteLine(sr.Read());
                Console.WriteLine(sr.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally      //in case of error /no then finally execute
            {
                Console.WriteLine("in finslly");
                if (sr != null)
                    sr.Close();
            }
        }
    }
}
