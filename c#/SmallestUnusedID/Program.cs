using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestUnusedID
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] UnusedID = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter {0} member of array a", i + 1);

                if (int.TryParse(Console.ReadLine(), out int newArrayElement))
                {
                    UnusedID.SetValue(newArrayElement, i);
                }
                else
                {
                    Console.WriteLine("Wrong element. Expected type int");
                    i--;
                }
            }

            int NextID = NextId(UnusedID);
            Console.WriteLine("Next ID is: {0}",NextID);
            Console.ReadLine();
        }


        public static int NextId(int[] ids)
        {
            int i = 0;
            while (ids.Contains(i))
            {
                i++;
            }
            return i;
        }
    }
}
