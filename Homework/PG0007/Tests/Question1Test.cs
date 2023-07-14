using System;
using System.Collections.Generic;
using NUnit.Framework;
using PG0007.Questions;
using static PG0007.Questions.Question1;

namespace PG0007.Tests
{
    public class Question1Test
    {
        [TestCase(0, 1)]
        [TestCase(30, 3)]
        [TestCase(10, 100)]
        [TestCase(300, 300)]
        [TestCase(200, 800)]
        public void TestMultiPop(int ready, int pop)
        {
            var factory = new BulletFactory();
            var pool = new Pool<Bullet>(factory);
            pool.Ready(ready);
            var bullets = pool.MultiPop(pop);
            HashSet<int> set = new HashSet<int>();
            foreach (var bullet in bullets)
            {
                set.Add(bullet.Id);
            }
            Assert.AreEqual(bullets.Length, set.Count);
            Assert.DoesNotThrow(() => { pool.MultiPush(bullets); });
            // test push duplicate bullet
            Assert.DoesNotThrow(() => { pool.MultiPush(bullets); });

            /*
             * 物件池數量不足時，自動會增加32
             * 故可以預測出pool的count
             */
            int expected = ready;
            if (pop > ready) {
                expected += ((pop - ready) / 32 + ((pop - ready) % 32 > 0 ? 1 : 0)) * 32;
            }
            Assert.AreEqual(expected, pool.Count);
        }

        [Test]
        public void TestMultiPush_PoolNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                PoolExtension.MultiPush(null, new int[] { 1, 2, 3 });
            });
        }

        [Test]
        public void TestMultiPop_PoolNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                PoolExtension.MultiPop<int>(null, 3);
            });
        }

        [Test]
        public void TestMultiPop_NegativeCount()
        {
            var factory = new BulletFactory();
            var pool = new Pool<Bullet>(factory);
            Assert.Throws<ArgumentException>(() =>
            {
                PoolExtension.MultiPop(pool, -3);
            });
        }

    }
}
