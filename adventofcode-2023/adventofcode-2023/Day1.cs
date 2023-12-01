namespace AdventOfCode_2023
{
    public static class Day1
    {
        public static int AnswerPartOne()
        {
            Console.Write("Hello, solution for the 1. day part one: ");

            int sumOfCalibrationValues = 0;

            using (StreamReader sr = new StreamReader("Day1_input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() ?? "";
                    sumOfCalibrationValues += Helper.LineToCalibrationValuePartOne(line);
                }
                Console.WriteLine(sumOfCalibrationValues);
            }

            return sumOfCalibrationValues;
        }

        public static int AnswerPartTwo()
        {
            Console.Write("Hello, solution for the 1. day part two: ");

            int sumOfCalibrationValues = 0;

            using (StreamReader sr = new StreamReader("Day1_input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() ?? "";
                    int calibrationValue = Helper.LineToCalibrationValuePartTwo(line);
                    sumOfCalibrationValues += calibrationValue;
                }
                Console.WriteLine(sumOfCalibrationValues);
            }

            return sumOfCalibrationValues;
        }
    }
}
