using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SquareEveryDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your integer:");
            string InputNumberString = Console.ReadLine();
            int ProcessedInputNumber = SquareDigits(int.Parse(InputNumberString));
            Console.WriteLine($"Processed integer:\n{ProcessedInputNumber.ToString()}");
            Console.ReadLine();
        }

        static int SquareDigits(int n)
        {
            string nString = n.ToString();
            string Sign = String.Empty;
            int Digit;
            string ReturnValue = String.Empty;
            char[] CharArray = nString.ToArray();
            int StartPosition = 0;
            if (Math.Abs((decimal)n) - n != 0) { Sign = "-"; StartPosition = 1; }

            for (int i = StartPosition; i < CharArray.Length; i++)
            {
                Digit = int.Parse(CharArray[i].ToString());
                ReturnValue = string.Join(String.Empty, ReturnValue,(Digit*Digit).ToString());
            }
            ReturnValue = string.Join(String.Empty, Sign, ReturnValue);
            return int.Parse(ReturnValue);
        }
    }
}
