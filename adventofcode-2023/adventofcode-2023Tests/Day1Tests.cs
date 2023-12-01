using adventofcode_2023;

namespace adventofcode_2023Tests
{
    public class Day1Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PartOne()
        {
            Assert.AreEqual(56506, Day1a.Answer());
        }

        [Test]
        public void PartTwo()
        {
            Assert.AreEqual(56017, Day1b.Answer());
        }

        [Test]
        public void LineToCalibrationValuePartTwo()
        {
            Assert.AreEqual(67, Helper.LineToCalibrationValuePartTwo("tbsxkhhv6twozrtczg6seven"));
        }
    }
}