using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNumberPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int InputNumber;
            Console.WriteLine("Please input your integer");
            try
            {
                InputNumber = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
                
            }
            PrimeNumber newCheckableNumber = new PrimeNumber(InputNumber);
            newCheckableNumber.Solution();
            Console.WriteLine(newCheckableNumber.GetBoolOutput());
            Console.ReadLine();
            
        }
    }

    public interface Kata
    {
        int IntegerInput {  set; }
        bool BoolOutputValue { get; }
        void Solution();

        int GetIntegerInput();
        bool GetBoolOutput();

    }

    public class PrimeNumber : Kata
    {
        public int IntegerInput { get; set; }

        public bool BoolOutputValue { get; set; }

        public bool GetBoolOutput()
        {
            return BoolOutputValue;
        }

        public int GetIntegerInput()
        {
            return IntegerInput;
        }

        public void Solution()
        {

            switch (IntegerInput)
            {
                case 0:
                    BoolOutputValue = false;
                    return;
                case 1:
                    BoolOutputValue = false;
                    return;
                case -1:
                    BoolOutputValue = false;
                    return;
            }

            if(IntegerInput < 0)
            {
                BoolOutputValue = false;
                return;
            }
            double sqrtNumber = Math.Sqrt((double)IntegerInput);
            BoolOutputValue = true;
            for (double i = 2; i <= sqrtNumber; i++)
            {
                if((double)IntegerInput % i == 0)
                {
                    BoolOutputValue = false;
                    return;
                }
            }
        }

        public PrimeNumber(int InputNumber)
        {
            IntegerInput = InputNumber;
        }
    }
}
