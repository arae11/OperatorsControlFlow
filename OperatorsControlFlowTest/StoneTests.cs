using NUnit.Framework;
using OperatorsApp;

namespace OperatorsControlFlowTest
{

    public class StoneTests
    {
        [TestCase(156, 11)]
        [TestCase(140, 10)]
        [TestCase(8, 0)]
        [TestCase(0, 0)]
        public void GivenANumberOFPounds_GetStones_ReturnTheCorrectNumberOfStones(int pounds, int expStones)
        {
            var result = Methods.GetStones(pounds);
            Assert.That(result, Is.EqualTo(expStones));
        }

        [TestCase(156, 2)]
        [TestCase(140, 0)]
        [TestCase(8, 8)]
        [TestCase(0, 0)]
        public void GivenANumberOFPounds_GetPounds_ReturnTheCorrectNumberOfpounds(int pounds, int expPounds)
        {
            var result = Methods.GetPounds(pounds);
            Assert.That(result, Is.EqualTo(expPounds));
        }

        [TestCase(0)]
        [TestCase(40)]
        [TestCase(64)]
        public void GivenAMarkLessThan65_Grade_ReturnsFail(int mark)
        {
            Assert.That(Methods.Grade(mark), Is.EqualTo("Fail"));
        }

        [TestCase(65)]
        [TestCase(76)]
        [TestCase(84)]
        public void GivenAMarkBetween65And84_Grade_ReturnsPass(int mark)
        {
            Assert.That(Methods.Grade(mark), Is.EqualTo("Pass"));
        }

        [TestCase(85)]
        [TestCase(90)]
        [TestCase(99)]
        public void GivenAMarkBetween85AndAbove_Grade_ReturnDistinction(int mark)
        {
            Assert.That(Methods.Grade(mark), Is.EqualTo("Distinction"));
        }
    }
    }