using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizeNewMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] List = new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } };
            NewKata Members = new NewKata(List);
            IEnumerable<string> Solution = Members.ReturnValue();

            foreach(string s in Solution)
            {
                Console.WriteLine(s + " ");
            }
            Console.ReadLine();

        }
    }

    public interface Kata
    {
       string InputString {  set; }

        IEnumerable<string> ReturnValue();


    }

    public class NewKata : Kata
    {
        public string InputString { get;  set; }

        public int[][] data { get;  set; }

        public NewKata(int[][] List,string input = "")
        {
            InputString = input;
            data = List;
        }

        public IEnumerable<string> ReturnValue()
        {
            foreach (int[] Member in data)
            {
                if (Member[0] >= 55 && Member[1] > 7)
                {
                    yield return "Senior";

                }
                else
                {
                    yield return "Open";
                }

            }
        }
    }
}
