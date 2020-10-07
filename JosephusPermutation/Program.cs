using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JosephusPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> listOfElements = new List<object>();
            Console.WriteLine("Set numer of elements");
            int.TryParse(Console.ReadLine(), out int numberOfElements);
            for(int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine("Enter element of the list");
                listOfElements.Add(Console.ReadLine());
            }

            Console.WriteLine("Enter count");

            int.TryParse(Console.ReadLine(), out int count);

            List<object> PermutateList = JosephusPermutation(listOfElements,count);
            string ResultString = String.Empty;

            foreach(object element in PermutateList)
            {
                ResultString = String.Concat(ResultString,element, ' ');
            }

            Console.WriteLine($"After permutate: {ResultString}");
            Console.ReadLine();
         }

        public static List<object> JosephusPermutation(List<object> items, int k)
        {
            List<object> ResultList = new List<object>();
            int ListCount = 0;
            int Step = 0;
            int LastIndex = 0;

            while (items.Count != 0)
            {
                ListCount = items.Count;
                Step = k % ListCount;
                if()

            }

            return ResultList;
        }
    }
}
