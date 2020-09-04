using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your string:");
            CountingDuplicates KataSolution = new CountingDuplicates(Console.ReadLine());
            KataSolution.KataSolution();
            KataSolution.ShowResults();
        }
    }


    abstract class MyKata
    {
        abstract public string InputString { get; set; }
        
        abstract public void KataSolution();
        public MyKata(string InputLine = "")
        {
            InputString = InputLine;
        }

        abstract public void ShowResults();

        abstract public int GetIntReturnValue();
    }

    sealed class CountingDuplicates : MyKata
    {
        public override string InputString { get; set; }
        
        private int ReturnValue { get; set; }

        public CountingDuplicates(string InputLine) : base(InputLine) {}
     
        public override void KataSolution()
        {
          
            ReturnValue = 0;
            int IndexForArray = 0;

            string[] StringArray = new string[InputString.Length];
            string[] AlreadyProcessed = new string[InputString.Length];

            for(int i = 0; i < InputString.Length; i++)
            {
                StringArray[i] = InputString[i].ToString().ToUpper();
            }
           
            foreach(string Symbol in StringArray)
            {
                string[] FindingElements =  Array.FindAll(StringArray, x => x == Symbol);
                string[] AlreadyProcessedElements = Array.FindAll(AlreadyProcessed, x => x == Symbol);

                if (FindingElements.Length > 1 && AlreadyProcessedElements.Length == 0) { ReturnValue++; }
                AlreadyProcessed[IndexForArray] = Symbol;
                IndexForArray++;
            }
        }

        public sealed override int GetIntReturnValue()
        {
            return ReturnValue;
        }

        public sealed override void ShowResults()
        {

            Console.WriteLine($"This is the result:\n{ReturnValue}");
            Console.ReadLine();
        }
    }
}   
