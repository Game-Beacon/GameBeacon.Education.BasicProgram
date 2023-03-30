using NUnit.Framework;
using PG0002.Questions;

namespace PG0002.Tests
{
    public class Question1Test
    {
        private Question1 _question1;

        [SetUp]
        public void SetUp()
        {
            _question1 = new Question1();
        }

        [TestCase(9, new int[] { 7, 13, 25, 51, 100 })]
        [TestCase(0, new int[] { 0, 0, 0, 0, 0 })]
        [TestCase(1001, new int[] { 999, 2000, 4000, 8000, 16000, 32000, 64000, 128000, 256000, 512000, 1024000 })]
        public void CanWin_ReturnTrue(int status, int[] monsters)
        {
            Assert.IsTrue(_question1.CanWin(status, monsters));
        }

        [TestCase(11, new int[] { 7, 18, 37, 51, 100 })]
        public void CanWin_ReturnFalse(int status, int[] monsters)
        {
            Assert.IsFalse(_question1.CanWin(status, monsters));
        }
    }
}