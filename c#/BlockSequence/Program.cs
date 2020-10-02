using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entr your long");
            try
            {
                long Number = long.Parse(Console.ReadLine());
                Console.WriteLine(BlockSeq.solve(Number).ToString());
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                throw;
            }
            
        }
    }

    public class BlockSeq
    {

        public static int solve(long n)
        {
            string Part = String.Empty;
            string FinalString = String.Empty;

            List<string> BlockList = new List<string>();
            for (long x = 1;x<=n;x++)
            {
                Part = String.Empty;
                for(long y = 1;y<=x;y++)
                {
                    Part = String.Concat(Part, y.ToString());
                }
                BlockList.Add(Part);
            }

            FinalString = String.Concat(BlockList);

            long Numerator = 1;

            foreach(char Symbol in FinalString)
            {
                if(Numerator == n) { return int.Parse(Symbol.ToString()); }
                Numerator++;
            }
            return 0;
        }
    }
}
