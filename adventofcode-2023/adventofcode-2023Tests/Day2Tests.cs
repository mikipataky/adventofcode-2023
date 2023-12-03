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
            Assert.That(Helper.PowerOfTheGame("3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green"), Is.EqualTo(48));
            Assert.That(Helper.PowerOfTheGame("8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red"), Is.EqualTo(1560));
        }

        [Test]
        public void PartOne()
        {
            Assert.That(Day2.AnswerPartOne(), Is.EqualTo(2369));
        }

        [Test]
        public void PartTwo()
        {
            Assert.That(Day2.AnswerPartTwo(), Is.EqualTo(66363));
        }
    }
}
