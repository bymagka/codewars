using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace HighestAndLowest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your string:");
            string numbers = Console.ReadLine();
            string FinalString = HighestAndLowest(numbers);
            Console.WriteLine($"Processed string:\n {FinalString}");
            Console.ReadLine();
        }

        static string HighestAndLowest(string numbers)
        {
            int minValue = int.MaxValue; int MaxValue = int.MinValue;
            char Separator = ' ';
            string[] StringArray = numbers.Split(Separator);
            int IntDefinition;
            foreach(string Symbol in StringArray)
            {
                IntDefinition = int.Parse(Symbol);
                if(IntDefinition > MaxValue) { MaxValue = IntDefinition; }
                if(IntDefinition < minValue) { minValue = IntDefinition; }
            }
           
            return string.Join(" ", MaxValue.ToString(), minValue.ToString());
        }
    }
}
