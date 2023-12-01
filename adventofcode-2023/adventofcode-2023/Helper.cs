using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode_2023
{
    internal static class Helper
    {
        static public int LineToCalibrationValue(string line)
        {
            string numbers = new string(line.Where(c => !char.IsLetter(c)).ToArray());
            int firstNumber = int.Parse(numbers.First().ToString());
            int lastNumber = int.Parse(numbers.Last().ToString());
            return firstNumber * 10 + lastNumber;
        }

        static public string ConvertNumbersToDigits(string line)
        {
            string result = line.Replace("one", "1");
            result = result.Replace("two", "2");
            result = result.Replace("three", "3");
            result = result.Replace("four", "4");
            result = result.Replace("five", "5");
            result = result.Replace("six", "6");
            result = result.Replace("seven", "7");
            result = result.Replace("eight", "8");
            result = result.Replace("nine", "9");            

            return result;
        }

    }
}
