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
            Assert.AreEqual(639, Helper.PartNumber(enginSchematic, i, ref j));
            Assert.AreEqual(39, j);

            j = 37;
            Assert.AreEqual(639, Helper.PartNumber(enginSchematic, i, ref j));
            Assert.AreEqual(39, j);

            j = 36;
            Assert.AreEqual(639, Helper.PartNumber(enginSchematic, i, ref j));
            Assert.AreEqual(39, j);
        }

        [Test]
        public void IsPartNumber()
        {
            Assert.IsTrue(Helper.IsPartNumber(enginSchematic, 2, 24));
            Assert.IsFalse(Helper.IsPartNumber(enginSchematic, 1, 50));
        }


    }
}
