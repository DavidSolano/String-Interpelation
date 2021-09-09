using System;

namespace String_Interpelation
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime thisDate = new DateTime(2019, 1, 22);

            Console.WriteLine(thisDate.ToString("MMMM dd, yyyy"));

            Console.WriteLine(thisDate.ToString("yyyy.dd.MM"));

            Console.WriteLine("Day " + thisDate.Day + " of " + thisDate.ToString("MMMM, yyyy"));

            Console.WriteLine("Year: " + thisDate.Year + "," + " Month: " + thisDate.Month + "," + " Day: " + thisDate.Day);

            Console.WriteLine(thisDate.ToString("dddd").PadLeft(17));

            DateTimeOffset thisDate2 = new DateTimeOffset(2019, 1, 22, 11, 1, 27, TimeSpan.Zero);

            Console.WriteLine(thisDate2.ToString("hh:mm").PadLeft(8) + thisDate2.ToString("dddd").PadLeft(17));
            

            var pi = Math.PI;

            Console.WriteLine($"{pi:C}");

            Console.WriteLine($"{pi,10:F3}");


        }
    }
}
