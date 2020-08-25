using System;
using System.Linq;

namespace ArrayDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayA = new int[10];
            int[] ArrayB = new int[3];
            int[] newArray;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter {0} member of array a",i+1);

                if (int.TryParse(Console.ReadLine(), out int newArrayElement))
                {
                    ArrayA.SetValue(newArrayElement,i);
                }
                else
                {
                    Console.WriteLine("Wrong element. Expected type int");
                    i--;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter {0} member of array b",i+1);

                if (int.TryParse(Console.ReadLine(), out int newArrayElement))
                {
                    ArrayB.SetValue(newArrayElement, i);
                }
                else
                {
                    Console.WriteLine("Wrong element. Expected type int");
                    i--;
                }
            }
            newArray = ArrayDiff(ArrayA, ArrayB);

            string text = "";
            foreach(int member in newArray)
            {
                text = text + "" + member;
            }
            Console.WriteLine("new array:{0}",text);
        }

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            int ReturnArrayLength = 0;
            int ArrayValue = 0;

            for (int i = a.Length - 1;i >= 0; i--)
            {
                ArrayValue = a[i];
                if (!ArrayContainsTheValue(b, ArrayValue))
                {
                    ReturnArrayLength++;
                }
            }

            int[] ReturnArray = new int[ReturnArrayLength];
            int Iterator = 0;
            foreach (int number in a )
            {
                if (!ArrayContainsTheValue(b,number))
                {
                    ReturnArray[Iterator] = number;
                    Iterator++;
                }
            }
            return ReturnArray;
        }
        
        public static bool ArrayContainsTheValue(int[] a, int Value)
        {
            foreach(int ArrayValue in a)
            {
                if (ArrayValue.Equals(Value))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

