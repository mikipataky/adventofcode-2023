using AdventOfCode_2023;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2023Tests
{
    public class Day4Tests
    {
        [Test]        
        public void PartOne()
        {
            Assert.That(Day4.AnswerPartOne(), Is.EqualTo(27845));
        }
    }
}
