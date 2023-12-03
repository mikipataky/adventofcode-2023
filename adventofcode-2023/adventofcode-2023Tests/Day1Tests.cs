using AdventOfCode_2023;

namespace AdventOfCode_2023Tests
{
    public class Day1Tests
    {
        [Test]
        public void PartOne()
        {
            Assert.That(Day1.AnswerPartOne(), Is.EqualTo(56506));
        }

        [Test]
        public void PartTwo()
        {
            Assert.That(Day1.AnswerPartTwo(), Is.EqualTo(56017));
        }

        [Test]
        public void LineToCalibrationValuePartTwo()
        {
            Assert.That(Helper.LineToCalibrationValuePartTwo("tbsxkhhv6twozrtczg6seven"), Is.EqualTo(67));
        }

        [Test]
        public void LineToCalibrationValuePartOne()
        {
            Assert.That(Helper.LineToCalibrationValuePartOne("tbsxkhhv6twozrtczg6seven"), Is.EqualTo(66));
        }
    }
}