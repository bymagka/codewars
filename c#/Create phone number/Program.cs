using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_phone_number
{
    class Program
    {
        static void Main(string[] args)
        {
         List<int> NumbersList = new List<int>();

            for(int i = 0; i<10;i++)
            {
                Console.WriteLine("Input your number");
                try 
	            {	        
                NumbersList.Add(int.Parse(Console.ReadLine()));
	            }
	            catch (Exception e)
	            {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
		            return;
	            }
                
            }
            Console.WriteLine(Kata.CreatePhoneNumber(NumbersList.ToArray()));
            Console.ReadLine();
        }
    }

    static class Kata
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
         string returnValue;
       
        returnValue = $"({numbers[0].ToString()}{numbers[1].ToString()}{numbers[2].ToString()}) {numbers[3].ToString()}{numbers[4].ToString()}{numbers[5].ToString()}-{numbers[6].ToString()}{numbers[7].ToString()}{numbers[8].ToString()}{numbers[9].ToString()}";

        return returnValue;
        }
    }
}
