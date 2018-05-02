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
            string testString;
            Console.WriteLine("I will say what you say!");
            // Run a loop of repeating incoming text
            Console.WriteLine("Press CTRL-Z to exit.");
            do
            {
                Console.Write("   ");
                testString = Console.ReadLine();
                if (testString != null)
                    Console.WriteLine("      " + testString);
            } while (testString != null);
        }
    }
}
