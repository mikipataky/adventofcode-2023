using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2023
{
    static public class Day4
    {
        static public int AnswerPartOne()
        {
            Console.Write("Hello, solution for the 4. day part one: ");

            int totalPoints = 0;

            using (StreamReader sr = new StreamReader("Day4_input.txt"))
            {                
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() ?? "";
                    line = line.Replace("  ", " ").Split(":").Last();
                    string[] numbers = line.Split('|');
                    List<int> winningNumbers = new List<int>(numbers.First().Trim().Split(' ').ToList().ConvertAll(int.Parse));
                    List<int> havingNumbers = new List<int>(numbers.Last().Trim().Split(' ').ToList().ConvertAll(int.Parse));
                    int points = 0;
                    foreach (int winningNumber in winningNumbers) 
                    {
                        points += havingNumbers.Count(hn => hn == winningNumber);                       
                    }
                    if(points > 0)
                        totalPoints += (int)Math.Pow(2, points - 1);

                }
                

                Console.WriteLine(totalPoints);
            }

            return totalPoints;
        }

    }
}
