using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Isograms
{
    public class Kata
    {
        private int NumberOfKata;
        private string InputLine;
        public Kata(string InputLine, int numberOfKata = 0)
        {
            this.NumberOfKata = numberOfKata;
            this.InputLine = InputLine;
        }
        public static string SpinWords(string sentence)
        {
            char Separator = ' ';
            string[] StringArray = sentence.Split(Separator);
            for(int i = 0; i < StringArray.Length;i++)
            {
                if (StringArray[i].Length >= 5)
                {
                    char[] CharArray = StringArray[i].ToCharArray();
                    StringArray[i] = string.Join(String.Empty, CharArray.Reverse());
                }
            }
 
            return string.Join(" ",StringArray);
        }
        public bool IsInputLineAnIsogram()
        {
            char[] charArray = this.InputLine.ToUpper().ToCharArray();
            bool IsIsogram = true;

            for(int i = 0; i < this.InputLine.Length; i++)
            {
                for(int y =0; y < this.InputLine.Length; y++)
                {
                    if(i == y) { continue; }

                    if (charArray[i].Equals(charArray[y])) { IsIsogram = false; }
                }
            }
            return IsIsogram;
        }

        public bool IsInputLineAnIsogram(string InputString)
        {

            return InputString.ToLower().ToCharArray().Distinct().Count() == InputString.Length;
        }

        public string GetInputLine()
        {
            return this.InputLine;
        }
    }
}
