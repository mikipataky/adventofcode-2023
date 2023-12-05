using AdventOfCode_2023;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2023Tests
{
    public class Day3Tests
    {
        char[][] enginSchematic;

        [SetUp]
        public void Setup()
        {
            using (StreamReader sr = new StreamReader("Day3_input.txt"))
            {
                List<char[]> tempSchematic = new List<char[]>();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() ?? "";
                    tempSchematic.Add(line.ToCharArray());
                }
                enginSchematic = tempSchematic.ToArray();
            }
        }

        [Test]
        public void PartNumber()
        {
            int i = 2;
            int j = 38;
            Assert.That(Helper.PartNumber(enginSchematic, i, ref j), Is.EqualTo(639));
            Assert.That(j, Is.EqualTo(39));

            j = 37;
            Assert.That(Helper.PartNumber(enginSchematic, i, ref j), Is.EqualTo(639));
            Assert.That(j, Is.EqualTo(39));

            j = 36;
            Assert.That(Helper.PartNumber(enginSchematic, i, ref j), Is.EqualTo(639));
            Assert.That(j, Is.EqualTo(39));
        }

        [Test]
        public void IsPartNumber()
        {
            Assert.IsTrue(Helper.IsPartNumber(enginSchematic, 2, 24));
            Assert.IsFalse(Helper.IsPartNumber(enginSchematic, 1, 50));
            Assert.IsFalse(Helper.IsPartNumber(enginSchematic, 0, 15));
        }

        [Test]
        public void GearRatio()
        {
            int i = 8;
            int j = 31;
            Assert.That(Helper.GearRatio(enginSchematic, i, j), Is.EqualTo(145665));          

            i = 1;
            j = 9;
            Assert.That(Helper.GearRatio(enginSchematic, i, j), Is.EqualTo(0));                       
        }

        [Test]
        public void PartOne()
        {
            Assert.That(Day3.AnswerPartOne(), Is.EqualTo(539637));
        }

        [Test]
        public void PartTwo()
        {
            Assert.That(Day3.AnswerPartTwo(), Is.EqualTo(82818007));
        }
    }
}
