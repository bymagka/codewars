using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PersistentBugger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your long:");
            long InputLong = long.Parse(Console.ReadLine());

            Persist NewPersist = new Persist {n = InputLong};
            int OneDigitNumber = NewPersist.Persistence();
            Console.WriteLine($"Count of persistence:\n{OneDigitNumber.ToString()}");
            Console.WriteLine($"Property N:{NewPersist.n}");
            Console.ReadLine();
        }

        public class Persist
        {
            private long PropertyN;
            public long n
            {
                get => PropertyN;
                set => PropertyN = value;
            }

 
            public int Persistence()
            {
                int Iterator = 0; 

                PersistenceRecc(n,ref Iterator);

                return Iterator;
            }

            private static void PersistenceRecc(long RecValue, ref int Iterator)
            {
                if (RecValue.ToString().Length != 1) 
                {
                    
                    long Composition = 1;
                    foreach(char charValue in RecValue.ToString())
                    {
                        Composition *= long.Parse(charValue.ToString());
                    }
                    Iterator += 1;
                    PersistenceRecc(Composition,ref Iterator);
                }
            }
        }   
    }
}
