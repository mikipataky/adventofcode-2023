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

        static public int AnswerPartTwo()
        {
            Console.Write("Hello, solution for the 4. day part one: ");
            
            List<int> scratchcards = new List<int>() {1};

            int cardNumber = 0;
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

                    while (points + cardNumber >= scratchcards.Count - 1) 
                    { 
                        scratchcards.Add(1);
                    }

                    for (int i = 1; i <= points; i++)
                    {
                        scratchcards[cardNumber + i] += scratchcards[cardNumber];
                    }

                    cardNumber++;
                }                
            }

            int totalScratchcards = 0;
            scratchcards.RemoveRange(cardNumber, scratchcards.Count - cardNumber);
            scratchcards.ForEach(x => totalScratchcards += x);

            Console.WriteLine(totalScratchcards);

            return totalScratchcards;
        }

    }
}
