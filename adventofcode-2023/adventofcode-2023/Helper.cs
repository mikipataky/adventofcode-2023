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

            for (int i = 1; i <= NUMBERS.Length; i++)
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

        public static bool IsGamePossible(int redCubes, int greenCubes, int blueCubes, string game)
        {
            foreach (string cubes in game.Replace(';', ',').Split(','))
            {
                string[] countAndColor = cubes.Trim().Split(' ');
                string color = countAndColor[1];
                int count = int.Parse(countAndColor[0]);

                switch (color.ToLower())
                {
                    case "red": if (redCubes < count) return false; break;
                    case "green": if (greenCubes < count) return false; break;
                    case "blue": if (blueCubes < count) return false; break;
                }
            }

            return true;
        }

        public static int PowerOfTheGame(string game)
        {
            int result = 1;
            Dictionary<string, List<int>> cubesInGame = new Dictionary<string, List<int>>();

            foreach (string cubes in game.Replace(';', ',').Split(','))
            {
                string[] countAndColor = cubes.Trim().Split(' ');
                string color = countAndColor[1];
                int count = int.Parse(countAndColor[0]);

                if (cubesInGame.ContainsKey(color))
                    cubesInGame[color].Add(count);
                else
                {
                    cubesInGame[color] = new List<int>() { count };
                }
            }

            foreach (string color in cubesInGame.Keys)
            {
                cubesInGame[color].Sort();
                result *= cubesInGame[color].Last();
            }

            return result;
        }

        public static bool IsPartNumber(char[][] engineSchematic, int i, int j)
        {
            if (!Char.IsDigit(engineSchematic[i][j]))
                return false;

            int newi = i - 1;
            int newj = j;


            if (newi > -1 && newi < engineSchematic.Length && newj > -1 && newj < engineSchematic[newi].Length && engineSchematic[newi][newj] != '.' && !char.IsDigit(engineSchematic[newi][newj]))
                return true;

            newi = i - 1;
            newj = j - 1;
            if (newi > -1 && newi < engineSchematic.Length && newj > -1 && newj < engineSchematic[newi].Length && engineSchematic[newi][newj] != '.' && !char.IsDigit(engineSchematic[newi][newj]))
                return true;

            newi = i - 1;
            newj = j + 1;
            if (newi > -1 && newi < engineSchematic.Length && newj > -1 && newj < engineSchematic[newi].Length && engineSchematic[newi][newj] != '.' && !char.IsDigit(engineSchematic[newi][newj]))
                return true;

            newi = i;
            newj = j - 1;
            if (newi > -1 && newi < engineSchematic.Length && newj > -1 && newj < engineSchematic[newi].Length && engineSchematic[newi][newj] != '.' && !char.IsDigit(engineSchematic[newi][newj]))
                return true;

            newi = i;
            newj = j + 1;
            if (newi > -1 && newi < engineSchematic.Length && newj > -1 && newj < engineSchematic[newi].Length && engineSchematic[newi][newj] != '.' && !char.IsDigit(engineSchematic[newi][newj]))
                return true;

            newi = i + 1;
            newj = j - 1;
            if (newi > -1 && newi < engineSchematic.Length && newj > -1 && newj < engineSchematic[newi].Length && engineSchematic[newi][newj] != '.' && !char.IsDigit(engineSchematic[newi][newj]))
                return true;

            newi = i + 1;
            newj = j;
            if (newi > -1 && newi < engineSchematic.Length && newj > -1 && newj < engineSchematic[newi].Length && engineSchematic[newi][newj] != '.' && !char.IsDigit(engineSchematic[newi][newj]))
                return true;

            newi = i + 1;
            newj = j + 1;
            if (newi > -1 && newi < engineSchematic.Length && newj > -1 && newj < engineSchematic[newi].Length && engineSchematic[newi][newj] != '.' && !char.IsDigit(engineSchematic[newi][newj]))
                return true;

            return false;
        }

        public static int PartNumber(char[][] engineSchematic, int i, ref int j)
        {
            if (engineSchematic == null || !Char.IsDigit(engineSchematic[i][j]))
                throw new ArgumentException();

            int partNumber = Int32.Parse(engineSchematic[i][j].ToString());
            int newj = j - 1;
            int mutiply = 10;
            while (newj > -1 && Char.IsDigit(engineSchematic[i][newj]))
            {
                partNumber = Int32.Parse(engineSchematic[i][newj].ToString()) * mutiply + partNumber;
                newj -= 1;
                mutiply *= 10;
            }

            newj = j + 1;
            while (newj < engineSchematic[i].Length && Char.IsDigit(engineSchematic[i][newj]))
            {
                partNumber = Int32.Parse(engineSchematic[i][newj].ToString()) + partNumber * 10;
                newj = newj + 1;
            }
            j = newj;
            return partNumber;
        }

        public static int GearRatio(char[][] engineSchematic, int i, int j)
        {
            int gearRatio = 0;
            List<int> partNumbers = new List<int>();

            int newi = i - 1;
            int newj = j;
            if (newi > -1 && newi < engineSchematic.Length && newj > -1 && newj < engineSchematic[newi].Length && char.IsDigit(engineSchematic[newi][newj]))
                partNumbers.Add(PartNumber(engineSchematic, newi, ref newj));

            newi = i - 1;
            newj = j - 1;
            if (newi > -1 && newi < engineSchematic.Length && newj > -1 && newj < engineSchematic[newi].Length && char.IsDigit(engineSchematic[newi][newj]))
                partNumbers.Add(PartNumber(engineSchematic, newi, ref newj));

            newi = i - 1;
            newj = j + 1;
            if (newi > -1 && newi < engineSchematic.Length && newj > -1 && newj < engineSchematic[newi].Length && char.IsDigit(engineSchematic[newi][newj]))
                partNumbers.Add(PartNumber(engineSchematic, newi, ref newj));

            newi = i;
            newj = j - 1;
            if (newi > -1 && newi < engineSchematic.Length && newj > -1 && newj < engineSchematic[newi].Length && char.IsDigit(engineSchematic[newi][newj]))
                partNumbers.Add(PartNumber(engineSchematic, newi, ref newj));

            newi = i;
            newj = j + 1;
            if (newi > -1 && newi < engineSchematic.Length && newj > -1 && newj < engineSchematic[newi].Length && char.IsDigit(engineSchematic[newi][newj]))
                partNumbers.Add(PartNumber(engineSchematic, newi, ref newj));

            newi = i + 1;
            newj = j - 1;
            if (newi > -1 && newi < engineSchematic.Length && newj > -1 && newj < engineSchematic[newi].Length && char.IsDigit(engineSchematic[newi][newj]))
                partNumbers.Add(PartNumber(engineSchematic, newi, ref newj));


            newi = i + 1;
            newj = j + 1;
            if (newi > -1 && newi < engineSchematic.Length && newj > -1 && newj < engineSchematic[newi].Length && char.IsDigit(engineSchematic[newi][newj]))
                partNumbers.Add(PartNumber(engineSchematic, newi, ref newj));


            newi = i + 1;
            newj = j;
            if (newi > -1 && newi < engineSchematic.Length && newj > -1 && newj < engineSchematic[newi].Length && char.IsDigit(engineSchematic[newi][newj]))
                partNumbers.Add(PartNumber(engineSchematic, newi, ref newj));

            List<int> partNumbersDistinc = partNumbers.Distinct().ToList();
            if(partNumbersDistinc.Count() == 2)
                gearRatio = partNumbersDistinc.First() * partNumbersDistinc.Last();


            return gearRatio;
        }
    }
}
