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
            string testReverse;
            Console.WriteLine("I will say what you say, but backwards!");
            // Run a loop of repeating incoming text
            Console.WriteLine("Press CTRL-Z to exit.");
            do
            {
                Console.Write("   ");
                testString = Console.ReadLine();
                if (testString != null)
                {
                    testReverse = new string(testString.ToCharArray().Reverse().ToArray());
                    Console.WriteLine("      " + testReverse);
                }
            } while (testString != null);
        }
    }
}
