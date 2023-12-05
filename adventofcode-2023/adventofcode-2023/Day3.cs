using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2023
{
    public static class Day3
    {
        static public int AnswerPartOne()
        {
            Console.Write("Hello, solution for the 3. day part one: ");

            int sumOfPartsNumbers = 0;

            using (StreamReader sr = new StreamReader("Day3_input.txt"))
            {
                List<char[]> tempSchematic = new List<char[]>();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() ?? "";
                    tempSchematic.Add(line.ToCharArray());
                }
                char[][] enginSchematic = tempSchematic.ToArray();
                for (int i = 0; i < enginSchematic.Length; i++)
                {
                    for (int j = 0; j < enginSchematic[i].Length; j++)
                    {
                        if (Helper.IsPartNumber(enginSchematic, i, j))
                        {
                            sumOfPartsNumbers += Helper.PartNumber(enginSchematic, i, ref j);
                        }
                    }
                }

                Console.WriteLine(sumOfPartsNumbers);
            }

            return sumOfPartsNumbers;
        }

        static public int AnswerPartTwo()
        {

            Console.Write("Hello, solution for the 3. day part one: ");

            int sumOfGearRatio = 0;

            using (StreamReader sr = new StreamReader("Day3_input.txt"))
            {
                List<char[]> tempSchematic = new List<char[]>();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() ?? "";
                    tempSchematic.Add(line.ToCharArray());
                }
                char[][] enginSchematic = tempSchematic.ToArray();

                for (int i = 0; i < enginSchematic.Length; i++)
                {
                    for (int j = 0; j < enginSchematic[i].Length; j++)
                    {
                        if (enginSchematic[i][j] == '*')
                        {
                            sumOfGearRatio += Helper.GearRatio(enginSchematic, i, j);
                        }
                    }
                }

                Console.WriteLine(sumOfGearRatio);
            }

            return sumOfGearRatio;
        }
    }
}
