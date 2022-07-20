using System;
using System.Collections.Generic;

namespace Advancecsharp
{
    /// <summary>
    /// //2md program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<string> color = new List<string>() { "yellow","green","pink","yellow"};
           // color.AddLast("yellow");
           // color.AddLast("pink");
           // color.AddFirst("purple");
           // color.AddLast("green");
           // color.AddLast("blue");

            foreach (string c in color)
                Console.WriteLine(c);

        }
    }
}
