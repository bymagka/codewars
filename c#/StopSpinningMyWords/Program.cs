using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopSpinningMyWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your string");
            string InputString = Console.ReadLine();
            Console.WriteLine($"This is processed string:\n{Kata.SpinWords(InputString)}");
            Console.ReadLine();

            
        }
    }
}
