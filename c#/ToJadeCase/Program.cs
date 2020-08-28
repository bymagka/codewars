using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToJadeCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input;
            Console.WriteLine("Please input your string:");
            Input = Console.ReadLine();

            string JadenCase = ToJadenCase(Input);
            Console.WriteLine($"This is your string in Jaden case:\n {JadenCase}");
            Console.ReadLine();

        }

        static string ToJadenCase(string phrase)
        {
            char whitespace = ' ';
            string[] SubstringsArray = phrase.Split(whitespace);
 
            string ReturnValue = "";
            foreach(string Substring in SubstringsArray)
            {
                for(int i = 0; i < Substring.Length; i++)
                {
                    if(i==0) 
                    {
                        ReturnValue = ReturnValue + Substring[i].ToString().ToUpper();
                    }  
                    else
                    {
                        ReturnValue = ReturnValue + Substring[i];
                    }
                }
                ReturnValue = ReturnValue + " ";
               
            }
            return ReturnValue.TrimEnd(whitespace);
        }
    }
}
