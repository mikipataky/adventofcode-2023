﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode_2023
{
    internal static class Day1b
    {
        public static void Answer() //Something is wrong
        {
            Console.Write("Hello, solution for the 1. day part two: ");

            using (StreamReader sr = new StreamReader("Day1_input.txt"))
            {
                int sumOfCalibrationValues = 0;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() ?? "";                    
                    int calibrationValue = Helper.LineToCalibrationValuePartTwo(line);                    
                    sumOfCalibrationValues += calibrationValue;
                }
                Console.WriteLine(sumOfCalibrationValues);
            }
        }
    }
}
