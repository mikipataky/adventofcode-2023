namespace AdventOfCode_2023
{
    public static class Day2
    {
        public static int AnswerPartOne()
        {
            Console.Write("Hello, solution for the 2. day part one: ");

            int sumOfPossibleGames = 0;

            using (StreamReader sr = new StreamReader("Day2_input.txt"))
            {
                int gameNumber = 1;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() ?? "";
                    if (Helper.IsGamePossible(12, 13, 14, line.Split(':').Last()))
                        sumOfPossibleGames += gameNumber;
                    gameNumber++;
                }
                Console.WriteLine(sumOfPossibleGames);
            }

            return sumOfPossibleGames;
        }

        public static int AnswerPartTwo()
        {
            Console.Write("Hello, solution for the 2. day part one: ");

            int sumOfGamePower = 0;

            using (StreamReader sr = new StreamReader("Day2_input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() ?? "";
                    sumOfGamePower += Helper.PowerOfTheGame(line.Split(':').Last());
                }
                Console.WriteLine(sumOfGamePower);
            }

            return sumOfGamePower;
        }
    }
}
