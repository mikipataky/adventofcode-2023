﻿namespace AdventOfCode_2023
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

        public static bool IsPartNumber(char[][] enginSchematic, int i, int j)
        {
            if(!Char.IsDigit(enginSchematic[i][j]))
                return false;

            int newi = i - 1;
            int newj = j;

            if(newi > -1 && newi < enginSchematic.Length && newj > -1 && newj < enginSchematic[newi].Length && enginSchematic[newi][newj] != '.' && !char.IsDigit(enginSchematic[newi][newj]))
                return true;

            newi = i - 1;
            newj = j - 1;
            if (newi > -1 && newi < enginSchematic.Length && newj > -1 && newj < enginSchematic[newi].Length && enginSchematic[newi][newj] != '.' && char.IsDigit(enginSchematic[newi][newj]))
                return true;

            newi = i - 1;
            newj = j + 1;
            if (newi > -1 && newi < enginSchematic.Length && newj > -1 && newj < enginSchematic[newi].Length && enginSchematic[newi][newj] != '.' && char.IsDigit(enginSchematic[newi][newj]))
                return true;

            newi = i;
            newj = j - 1;
            if (newi > -1 && newi < enginSchematic.Length && newj > -1 && newj < enginSchematic[newi].Length && enginSchematic[newi][newj] != '.' && char.IsDigit(enginSchematic[newi][newj]))
                return true;

            newi = i;
            newj = j + 1;
            if (newi > -1 && newi < enginSchematic.Length && newj > -1 && newj < enginSchematic[newi].Length && enginSchematic[newi][newj] != '.' && char.IsDigit(enginSchematic[newi][newj]))
                return true;

            newi = i + 1;
            newj = j - 1;
            if (newi > -1 && newi < enginSchematic.Length && newj > -1 && newj < enginSchematic[newi].Length && enginSchematic[newi][newj] != '.' && char.IsDigit(enginSchematic[newi][newj]))
                return true;

            newi = i + 1;
            newj = j;
            if (newi > -1 && newi < enginSchematic.Length && newj > -1 && newj < enginSchematic[newi].Length && enginSchematic[newi][newj] != '.' && char.IsDigit(enginSchematic[newi][newj]))
                return true;

            newi = i + 1;
            newj = j + 1;
            if (newi > -1 && newi < enginSchematic.Length && newj > -1 && newj < enginSchematic[newi].Length && enginSchematic[newi][newj] != '.' && char.IsDigit(enginSchematic[newi][newj]))
                return true;

            return false;
        }

        public static int PartNumber(char[][] enginSchematic, int i, ref int j)
        {
            if(enginSchematic == null || enginSchematic[i][j] == null || !Char.IsDigit(enginSchematic[i][j]))
                throw new ArgumentException();

            int partNumber = Int32.Parse(enginSchematic[i][j].ToString());
            int newj = j - 1;
            int mutiply = 10;
            while (newj > -1 && Char.IsDigit(enginSchematic[i][newj]))
            {
                partNumber = Int32.Parse(enginSchematic[i][newj].ToString()) * mutiply + partNumber;
                newj -= 1;
                mutiply *= 10;
            }

            newj = j + 1;
            while(newj < enginSchematic[i].Length && Char.IsDigit(enginSchematic[i][newj]))
            {
                partNumber = Int32.Parse(enginSchematic[i][newj].ToString()) + partNumber * 10;
                newj = newj + 1;
            }
            j = newj;
            return partNumber;
        }
    }
}
