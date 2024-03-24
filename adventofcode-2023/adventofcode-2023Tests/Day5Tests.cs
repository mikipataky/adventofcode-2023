using AdventOfCode_2023;

namespace AdventOfCode_2023Tests
{
    public class Day5Tests
    {
        [Test]
        public void PartOne_small()
        {
            Assert.That(Day5.AnswerPartOne("Day5_small_input.txt"), Is.EqualTo(35));
        }

        [Test]
        public void PartOne()
        {
            Assert.That(Day5.AnswerPartOne(), Is.EqualTo(35));
        }

        public void PartTwo()
        {
            Assert.That(Day5.AnswerPartOne(), Is.EqualTo(0));
        }
    }
}
