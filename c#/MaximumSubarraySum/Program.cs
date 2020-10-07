using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSubarraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ValueList = new List<int>();
            Console.WriteLine("Input integer");
            string InputLine = Console.ReadLine();
            while (InputLine != "stop")
            {
                if(int.TryParse(InputLine, out int output)) ValueList.Add(output);

                Console.WriteLine("Input next int");
                InputLine = Console.ReadLine();
            }
            int Sum = MaxSequence(ValueList.ToArray());
            Console.WriteLine($"Max sum is {Sum}");
            Console.ReadLine();

        }

        public static int MaxSequence(int[] arr)
        {
            if (arr.Count() == 0) return 0;
            if(arr.Where(x => x > 0).Count() == 0) return 0;
            if (arr.Where(x => x > 0).Count() == arr.Count()) return arr.Sum();

            int sum = 0;
            int answer = arr[0];
            foreach(int i in arr)
            {
                sum += i;
                answer = Math.Max(sum, answer);
                sum = Math.Max(sum, 0);
            }

            return answer;
        }
    }
}
