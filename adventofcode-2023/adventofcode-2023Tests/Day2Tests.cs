using AdventOfCode_2023;

namespace AdventOfCode_2023Tests
{
    public class Day2Tests
    {
        [Test]
        public void IsGamePossible()
        {
            Assert.IsTrue(Helper.IsGamePossible(12, 13, 14, "3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green"));
            Assert.IsFalse(Helper.IsGamePossible(12, 13, 14, "8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red"));
        }

        [Test]
        public void PowerOfTheGame()
        {
            Assert.AreEqual(48, Helper.PowerOfTheGame("3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green"));
            Assert.AreEqual(1560, Helper.PowerOfTheGame("8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red"));
        }

        [Test]
        public void PartOne()
        {
            Assert.AreEqual(2369, Day2.AnswerPartOne());
        }
    }
}
