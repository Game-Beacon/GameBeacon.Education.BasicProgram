using NUnit.Framework;
using PG0001.Questions;

namespace PG0001.Tests
{
    public class Question1Test
    {
        private Question1 _question1;

        [SetUp]
        public void SetUp()
        {
            _question1 = new Question1();
        }

        [TestCase(0, 1f, 0f)]
        [TestCase(20, 1f, 0.9999f)]
        [TestCase(99, 0.2f, 0.1f)]
        public void CriticalAtk_Crit(int atk, float critRate, float rand)
        {
            Assert.AreEqual((int)(atk * 1.5f), _question1.CriticalAtk(atk, critRate, rand));
        }

        [TestCase(0, 1f, 0f)]
        [TestCase(20, 0f, 0f)]
        [TestCase(99, 0.2f, 0.21f)]
        public void CriticalAtk_NoCrit(int atk, float critRate, float rand)
        {
            Assert.AreEqual(atk, _question1.CriticalAtk(atk, critRate, rand));
        }

        [TestCase(0, 1f, 0f)]
        [TestCase(-99, 0.2f, 0.1f)]
        [TestCase(-99, 0.2f, 0.2f)]
        public void CriticalAtk_NegativeAtk(int atk, float critRate, float rand)
        {
            Assert.AreEqual(0, _question1.CriticalAtk(atk, critRate, rand));
        }

    }
}
