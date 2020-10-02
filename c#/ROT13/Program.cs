using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROT13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your string");
            string inputString = Console.ReadLine();

            ROT13Implementation rot13 = new ROT13Implementation();
            Console.WriteLine($"This is rot13 decipher: {rot13.DecipherROT13(inputString)}");
            Console.ReadLine();
        }
    }

    class ROT13Implementation
    {
        private List<char> Alphabet = new List<char>();
        private List<char> ROT13 = new List<char>();

        public ROT13Implementation()
        {
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                Alphabet.Add(letter);
            }
        }

        public string DecipherROT13(string InputString)
        {
            int Count = Alphabet.Count - 1;
            foreach (char Symbol in InputString)
            {

                if (!Alphabet.Contains(char.ToUpper(Symbol)))
                {
                    ROT13.Add(Symbol);
                    continue;
                }

                int indexOfSymbol = Alphabet.IndexOf(char.ToUpper(Symbol));

                    if (Count - indexOfSymbol >= 13)
                    {
                        if (char.IsUpper(Symbol))
                        {
                            ROT13.Add(char.ToUpper(Alphabet[indexOfSymbol + 13]));
                        }
                        else
                        {
                            ROT13.Add(char.ToLower(Alphabet[indexOfSymbol + 13]));
                        }
                       
                    }
                    
                else
                {
                    if (char.IsUpper(Symbol))
                    {
                        ROT13.Add(char.ToUpper(Alphabet[13 - (Count - indexOfSymbol + 1)]));
                    }
                    else
                    {
                        ROT13.Add(char.ToLower(Alphabet[13 - (Count - indexOfSymbol + 1)]));
                    }
                }
                
            }

            return new string(ROT13.ToArray());
        }


    }
}
