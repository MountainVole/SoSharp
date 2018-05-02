using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I will say what you say!");
            // Keep the console window open in debug mode.
            Console.Write("  ");
            string testString;
            testString=Console.ReadLine();
            Console.WriteLine("    " + testString);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
