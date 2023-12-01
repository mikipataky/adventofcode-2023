using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        static public int LineToCalibrationValuePartTwo(string line)
        {
            int firstCalibrationNumber = FindFirstNumber(line);
            int lastCalibrationNumber = FindLastNumber(line);
            return firstCalibrationNumber * 10 + lastCalibrationNumber;
        }

        private static int FindLastNumber(string line)
        {
            int result = 0;
            int index = -1;
            int newIndex = index;          

            newIndex = line.LastIndexOf("one");
            if (newIndex > index)
            {
                index = newIndex;
                result = 1;
            }

            newIndex = line.LastIndexOf("1");
            if (newIndex > index)
            {
                index = newIndex;
                result = 1;
            }

            newIndex = line.LastIndexOf("two");
            if (newIndex > index)
            {
                index = newIndex;
                result = 2;
            }

            newIndex = line.LastIndexOf("2");
            if (newIndex > index)
            {
                index = newIndex;
                result = 2;
            }

            newIndex = line.LastIndexOf("three");
            if (newIndex > index)
            {
                index = newIndex;
                result = 3;
            }

            newIndex = line.LastIndexOf("3");
            if (newIndex > index)
            {
                index = newIndex;
                result = 3;
            }

            newIndex = line.LastIndexOf("four");
            if (newIndex > index)
            {
                index = newIndex;
                result = 4;
            }

            newIndex = line.LastIndexOf("4");
            if (newIndex > index)
            {
                index = newIndex;
                result = 4;
            }

            newIndex = line.LastIndexOf("five");
            if (newIndex > index)
            {
                index = newIndex;
                result = 5;
            }

            newIndex = line.LastIndexOf("5");
            if (newIndex > index)
            {
                index = newIndex;
                result = 5;
            }

            newIndex = line.LastIndexOf("six");
            if (newIndex > index)
            {
                index = newIndex;
                result = 6;
            }

            newIndex = line.LastIndexOf("6");
            if (newIndex > index)
            {
                index = newIndex;
                result = 6;
            }

            newIndex = line.LastIndexOf("seven");
            if (newIndex > index)
            {
                index = newIndex;
                result = 7;
            }

            newIndex = line.LastIndexOf("7");
            if (newIndex > index)
            {
                index = newIndex;
                result = 7;
            }

            newIndex = line.LastIndexOf("eight");
            if (newIndex > index)
            {
                index = newIndex;
                result = 8;
            }

            newIndex = line.LastIndexOf("8");
            if (newIndex > index)
            {
                index = newIndex;
                result = 8;
            }

            newIndex = line.LastIndexOf("nine");
            if (newIndex > index)
            {
                index = newIndex;
                result = 9;
            }

            newIndex = line.LastIndexOf("9");
            if (newIndex > index)
            {
                index = newIndex;
                result = 9;
            }

            return result;
        }

        private static int FindFirstNumber(string line)
        {
            int result = 0;
            int index = line.Length;
            int newIndex = index;

            newIndex = line.IndexOf("one");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 1;
            }

            newIndex = line.IndexOf("1");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 1;
            }

            newIndex = line.IndexOf("two");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 2;
            }

            newIndex = line.IndexOf("2");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 2;
            }

            newIndex = line.IndexOf("three");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 3;
            }

            newIndex = line.IndexOf("3");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 3;
            }

            newIndex = line.IndexOf("four");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 4;
            }

            newIndex = line.IndexOf("4");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 4;
            }

            newIndex = line.IndexOf("five");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 5;
            }

            newIndex = line.IndexOf("5");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 5;
            }

            newIndex = line.IndexOf("six");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 6;
            }

            newIndex = line.IndexOf("6");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 6;
            }

            newIndex = line.IndexOf("seven");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 7;
            }

            newIndex = line.IndexOf("7");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 7;
            }

            newIndex = line.IndexOf("eight");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 8;
            }

            newIndex = line.IndexOf("8");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 8;
            }

            newIndex = line.IndexOf("nine");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 9;
            }

            newIndex = line.IndexOf("9");
            if (newIndex > -1 && newIndex < index)
            {
                index = newIndex;
                result = 9;
            }

            return result;
        }
    }
}
