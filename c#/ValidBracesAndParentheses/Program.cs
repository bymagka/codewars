using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace CountingDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your string:");
            SubKata newSubkata = new SubKata(Console.ReadLine());
            newSubkata.DeleteLiterals();
            newSubkata.ValidBraces();
            newSubkata.CheckAndPrintVaidation();
        }
    }

    class Kata
    {
        private string InputLine;
        public string InputChar
        {
            get => InputLine;
            set => InputLine = value;
        }

        public bool Validproperty
        {
            get;
            set;
        }

        public Kata(string Input)
        {
            InputChar = Input;
        }


        public void ValidBraces()
        {
            Validproperty = true;
            if(InputChar.Length % 2 != 0)
            {
                Validproperty = false;
                return;
            }
            char[] OpenedBraces           = new char[InputChar.Length / 2];
            int PositionOfLastOpenedBrace = -1;
           
            foreach(char Symbol in InputChar)
            {
                if (IsOpenBrace(Symbol.ToString()))
                {
                    PositionOfLastOpenedBrace++;
                    if(PositionOfLastOpenedBrace > OpenedBraces.Length - 1) { Validproperty = false; return; }
                    OpenedBraces[PositionOfLastOpenedBrace] = Symbol;
                    
                }
                else
                {
                    if(PositionOfLastOpenedBrace < 0) { Validproperty = false; break; }
                    if (Symbol.ToString().Equals(CompareBraces(OpenedBraces[PositionOfLastOpenedBrace].ToString())))
                    {
                        PositionOfLastOpenedBrace--;
                    }
                    else
                    {
                        Validproperty = false;
                        break;
                    }
                }
 
            }
            if (PositionOfLastOpenedBrace >= 0)
            {
                Validproperty = false;
            }

        }


        private bool IsOpenBrace(string Brace)
        {
            switch (Brace)
            {
                case "{":
                    return true;
                case "[":
                    return true;
                case "(":
                    return true;
                default:
                    return false;
            }

        }
        private string CompareBraces(string Brace)
        {
            switch (Brace)
            {
                case "{":
                    return "}";
                case "[":
                    return "]";
                case "(":
                    return ")";
                default: 
                    return String.Empty;
            }
                
        }
    }

    class SubKata : Kata
    {
        public bool ValidParentheses { get; set;}

        public SubKata(string Input) : base(Input) 
        {
        }

        public void DeleteLiterals()
        {
            string pattern = @"\w";
            InputChar = Regex.Replace(InputChar, pattern, String.Empty, RegexOptions.IgnoreCase);
        }
        public void CheckAndPrintVaidation()
        {
            Console.WriteLine($"The string has valid braces:{Validproperty}");
            Console.ReadLine();
        }
        

   
    }
}

