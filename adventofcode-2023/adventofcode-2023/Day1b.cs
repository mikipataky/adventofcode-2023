namespace adventofcode_2023
{
    public static class Day1b
    {
        public static int Answer() 
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
