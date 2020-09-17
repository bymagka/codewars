using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_of_3_or_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(Kata.Solution(number).ToString());
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }
        }
    }

    static class Kata
    {
        public static int Solution(int value)
        {
            if(value < 0) { return 0; }
            int sum = 0;
            List<int> DivisorsList = new List<int>();

            int Numerator = 3;
            while (Numerator < value)
            {
                if(Numerator%3 == 0)
                {
                    DivisorsList.Add(Numerator);
                    sum += Numerator;
                    Numerator += 3;                    
                }
                else { Numerator++; }
            }
            Numerator = 5;
            while (Numerator < value)
            {
                if (Numerator % 5 == 0)
                {
                    if (DivisorsList.Find(x => x == Numerator) != 0)
                    {
                        Numerator += 5;
                        continue;
                    }
                    DivisorsList.Add(Numerator);
                    sum += Numerator;
                    Numerator += 5;
                }
                else { Numerator++; }
            }
            return sum;
        }
    }
}
