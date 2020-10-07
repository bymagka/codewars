using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanReadableTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of seconds");
            int.TryParse(Console.ReadLine(),out int Seconds);

            HumanReadableTime readableTime = new HumanReadableTime();
            Console.WriteLine($"This is your time: {readableTime.GetReadableTime(ref Seconds)}");
            Console.ReadLine();
        }

    }

    class HumanReadableTime
    {
       
        private readonly int SecondsInMinute = 60;
        private readonly int SecondsInHours = 60 * 60;

        public string GetReadableTime(ref int seconds)
        {
            string Hours = (seconds / SecondsInHours).ToString();
            if (Hours.Count() == 1) Hours = '0' + Hours;
            seconds = seconds % SecondsInHours;

            string Minutes = (seconds / SecondsInMinute).ToString();
            if (Minutes.Count() == 1) Minutes = '0' + Minutes;
            seconds = seconds % SecondsInMinute;

            string Seconds = seconds.ToString();
            if (Minutes.Count() == 1) Seconds = '0' + Seconds;
            

            return $"{Hours}:{Minutes}:{Seconds}";
        }
    }
}
