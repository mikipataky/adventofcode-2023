using AdventOfCode_2023;

namespace AdventOfCode_2023Tests
{
    public class Day1Tests
    {
        [Test]
        public void PartOne()
        {
            Assert.AreEqual(56506, Day1.AnswerPartOne());
        }

        [Test]
        public void PartTwo()
        {
            Assert.AreEqual(56017, Day1.AnswerPartTwo());
        }

        [Test]
        public void LineToCalibrationValuePartTwo()
        {
            Assert.AreEqual(67, Helper.LineToCalibrationValuePartTwo("tbsxkhhv6twozrtczg6seven"));
        }

        [Test]
        public void LineToCalibrationValuePartOne()
        {
            Assert.AreEqual(66, Helper.LineToCalibrationValuePartOne("tbsxkhhv6twozrtczg6seven"));
        }
    }
}