using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPanagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your string");
            string inputString = Console.ReadLine();

            ROT13Implementation rot13 = new ROT13Implementation();
            Console.WriteLine($"This is panagram: {rot13.IsPangram(inputString)}");
            Console.ReadLine();
        }
    }

    class ROT13Implementation
    {
        private List<char> Alphabet = new List<char>();
        private List<char> ExistingSymbols = new List<char>();

        public ROT13Implementation()
        {
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                Alphabet.Add(letter);
            }
        }

        public bool IsPangram(string str)
        {
            foreach(char Symbol in str)
            {
                if (!char.IsLetter(Symbol)) continue;

                if (Alphabet.Contains(char.ToUpper(Symbol)) && !ExistingSymbols.Contains(char.ToUpper(Symbol))) ExistingSymbols.Add(char.ToUpper(Symbol));
            }
            return Alphabet.Count == ExistingSymbols.Count;
        }
    }
}
