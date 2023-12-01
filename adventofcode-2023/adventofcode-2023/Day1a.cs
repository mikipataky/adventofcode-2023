using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode_2023
{
    internal static class Day1a
    {
        public static void Answer() {
            Console.Write("Hello, solution for the 1. day part one: ");

            using (StreamReader sr = new StreamReader("Day1_input.txt"))
            {
                int sumOfCalibrationValues = 0;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() ?? "";
                    sumOfCalibrationValues += Helper.LineToCalibrationValue(line);
                }
                Console.WriteLine(sumOfCalibrationValues);
            }
        }
    }
}
