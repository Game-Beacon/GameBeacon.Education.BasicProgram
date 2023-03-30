using NUnit.Framework;
using PG0002.Questions;

namespace PG0002.Tests
{
    public class Question2Test
    {
        private Question2 _question2;

        [SetUp]
        public void SetUp()
        {
            _question2 = new Question2();
        }

        [TestCase(18, new EElemental[] { EElemental.Fire, EElemental.Wind, EElemental.Water }, new int[] { 33, 25, 150 }, new EElemental[] { EElemental.Wind, EElemental.Fire, EElemental.Fire })]
        [TestCase(0, new EElemental[] { EElemental.Fire, EElemental.Wind, EElemental.Water, EElemental.None }, new int[] { 0, 0, 0, 0 }, new EElemental[] { EElemental.None, EElemental.Water, EElemental.Fire, EElemental.Wind })]
        public void CanWin_ReturnTrue(int status, EElemental[] elementals, int[] monsters, EElemental[] monsterElementals)
        {
            Assert.IsTrue(_question2.CanWin(status, elementals, monsters, monsterElementals));
        }

        [TestCase(1000, new EElemental[] { EElemental.Fire }, new int[] { 501 }, new EElemental[] { EElemental.Water })]
        public void CanWin_ReturnFalse(int status, EElemental[] elementals, int[] monsters, EElemental[] monsterElementals)
        {
            Assert.IsFalse(_question2.CanWin(status, elementals, monsters, monsterElementals));
        }
    }
}
