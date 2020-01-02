using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program1
    {
        static void Main(string[] args)
        {
            string name, country;
            Console.Write("Please enter your name:");
            name = Console.ReadLine();
            Console.Write("Please enter your country:");
            country = Console.ReadLine();
            Console.WriteLine("Hello {0} from country {1}!", name, country);
            Console.ReadLine();
        }
    }
}