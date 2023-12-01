namespace adventofcode_2023
{
    public static class Day1a
    {
        public static int Answer() 
        {
            Console.Write("Hello, solution for the 1. day part one: ");

            int sumOfCalibrationValues = 0;

            using (StreamReader sr = new StreamReader("Day1_input.txt"))
            {                
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() ?? "";
                    sumOfCalibrationValues += Helper.LineToCalibrationValue(line);
                }
                Console.WriteLine(sumOfCalibrationValues);
            }

            return sumOfCalibrationValues;
        }
    }
}
