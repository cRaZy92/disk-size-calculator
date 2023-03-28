using System;
using System.Globalization;

namespace DiskSizeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get disk size from user
            Console.WriteLine("Enter disk size (GB):");
            int wantedSize = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // Create formatter to format final result number
            NumberFormatInfo formatter = new NumberFormatInfo { NumberGroupSeparator = " ", NumberDecimalDigits = 0 };

            // Calculate size
            int modifiedSize = wantedSize * 1024;
            modifiedSize += (int)Math.Round(wantedSize * 0.8f);


            // Write result
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(wantedSize +"GB disk should have exactly " + modifiedSize.ToString("n", formatter) + "MB. Maybe :)");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPress enter to close...");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
