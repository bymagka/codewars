using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isograms
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Input your string:");

            Kata NewKata = new Kata(InputLine: Console.ReadLine());

            Console.WriteLine($"String is an isogram:{ NewKata.IsInputLineAnIsogram().ToString()}");
            Console.ReadLine();

            Console.WriteLine($"String is an isogram:{ NewKata.IsInputLineAnIsogram(NewKata.GetInputLine()).ToString()}");
            Console.ReadLine();

        }
    }
}
