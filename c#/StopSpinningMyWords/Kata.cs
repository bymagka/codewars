using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopSpinningMyWords
{
    public class Kata
    {
        private int NumberOfKata;

        public Kata(int numberOfKata)
        {
            this.NumberOfKata = numberOfKata;
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
    }
}
