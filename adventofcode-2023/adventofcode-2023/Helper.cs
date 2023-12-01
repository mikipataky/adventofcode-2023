namespace AdventOfCode_2023
{
    public static class Helper
    {
        static string[] NUMBERS = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        static public int LineToCalibrationValuePartOne(string line)
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
            int newIndex;

            for(int i = 1; i <= NUMBERS.Length; i++)
            {
                newIndex = Math.Max(line.LastIndexOf(NUMBERS[i - 1]), line.LastIndexOf(i.ToString()));
                if (newIndex > index)
                {
                    index = newIndex;
                    result = i;
                }
            }

            return result;
        }

        private static int FindFirstNumber(string line)
        {
            int result = 0;
            int index = line.Length;
            int newIndex;

            for (int i = 1; i <= NUMBERS.Length; i++)
            {
                newIndex = line.IndexOf(NUMBERS[i - 1]);
                if (newIndex > -1 && newIndex < index)
                {
                    index = newIndex;
                    result = i;
                }

                newIndex = line.IndexOf(i.ToString());
                if (newIndex > -1 && newIndex < index)
                {
                    index = newIndex;
                    result = i;
                }
            }

            return result;
        }
    }
}
