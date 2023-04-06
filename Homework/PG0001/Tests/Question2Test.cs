using NUnit.Framework;
using PG0001.Questions;

namespace PG0001.Tests
{
    public class Question2Test
    {
        private Question2 _question2;

        [SetUp]
        public void SetUp()
        {
            _question2 = new Question2();
        }

        [TestCase(1f, 0.9999f)]
        [TestCase(1f, 0f)]
        public void Dodge_ReturnTrue(float dodgeRate, float rand)
        {
            Assert.True(_question2.Dodge(dodgeRate, rand));
        }

        [TestCase(0.9998f, 0.9999f)]
        [TestCase(0f, 0f)]
        public void Dodge_ReturnFalse(float dodgeRate, float rand)
        {
            Assert.False(_question2.Dodge(dodgeRate, rand));
        }

        [TestCase(1f, 0.9999f)]
        [TestCase(1f, 0f)]
        public void Block_ReturnTrue(float blockRate, float rand)
        {
            Assert.True(_question2.Block(blockRate, rand));
        }

        [TestCase(0.9998f, 0.9999f)]
        [TestCase(0f, 0f)]
        public void Block_ReturnFalse(float blockRate, float rand)
        {
            Assert.False(_question2.Block(blockRate, rand));
        }

        [TestCase(100.1f, 0f, 1f, 0.9999f, 0.9999f)]
        [TestCase(100.1f, 1f, 0f, 0.9999f, 0.9999f)]
        [TestCase(100.1f, 1f, 1f, 0.9999f, 0.9999f)]
        public void Damage_DodgedOrBlocked(float atk, float dodgeRate, float blockRate, float dodgeRand, float blockRand)
        {
            Assert.AreEqual(0, _question2.Damage(atk, dodgeRate, blockRate, dodgeRand, blockRand));
        }

        [TestCase(100.1f, 0f, 0f, 0f, 0f)]
        [TestCase(100.1f, 0.5f, 0f, 0.5001f, 0f)]
        [TestCase(100.1f, 0f, 0.5f, 0f, 0.5001f)]
        public void Damage_NeitherDodgedOrBlocked(float atk, float dodgeRate, float blockRate, float dodgeRand, float blockRand)
        {
            Assert.AreEqual((int)atk, _question2.Damage(atk, dodgeRate, blockRate, dodgeRand, blockRand));
        }

        [TestCase(-100.1f, 0f, 0f, 0f, 0f)]
        [TestCase(-100.1f, 0.5f, 0f, 0.5001f, 0f)]
        [TestCase(-100.1f, 0f, 0.5f, 0f, 0.5001f)]
        [TestCase(-100.1f, 0f, 1f, 0.9999f, 0.9999f)]
        [TestCase(-100.1f, 1f, 0f, 0.9999f, 0.9999f)]
        [TestCase(-100.1f, 1f, 1f, 0.9999f, 0.9999f)]
        public void Damage_NegativeAtk(float atk, float dodgeRate, float blockRate, float dodgeRand, float blockRand)
        {
            Assert.AreEqual(0, _question2.Damage(atk, dodgeRate, blockRate, dodgeRand, blockRand));
        }
    }
}
