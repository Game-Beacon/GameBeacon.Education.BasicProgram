using NUnit.Framework;
using PG0004.Questions;
using System;
using System.Numerics;

namespace PG0004.Tests
{
    public class Question1Test
    {
        private const float kEpsilon = 1E-05f;

        [TestCase(-1, -1, 1, 1)]
        [TestCase(0.2f, 0.3f, 0.7f, 0.9f)]
        public void TestOperatorPlus(float x1, float y1, float x2, float y2)
        {
            float xExpect = x1 + x2;
            float yExpect = y1 + y2;
            Question1.Vector2 v1 = new Question1.Vector2(x1, y1);
            Question1.Vector2 v2 = new Question1.Vector2(x2, y2);
            Question1.Vector2 actual = v1 + v2;
            Assert.That(actual.x, Is.EqualTo(xExpect).Within(kEpsilon));
            Assert.That(actual.y, Is.EqualTo(yExpect).Within(kEpsilon));
        }

        [TestCase(-1, -1, 1, 1)]
        [TestCase(0.2f, 0.3f, 0.7f, 0.9f)]
        public void TestOperatorSubtract(float x1, float y1, float x2, float y2)
        {
            float xExpect = x1 - x2;
            float yExpect = y1 - y2;
            Question1.Vector2 v1 = new Question1.Vector2(x1, y1);
            Question1.Vector2 v2 = new Question1.Vector2(x2, y2);
            Question1.Vector2 actual = v1 - v2;
            Assert.That(actual.x, Is.EqualTo(xExpect).Within(kEpsilon));
            Assert.That(actual.y, Is.EqualTo(yExpect).Within(kEpsilon));
        }

        [TestCase(-1, -1, 2)]
        [TestCase(0.2f, 0.3f, 4)]
        public void TestOperatorMultiple(float x, float y, float f)
        {
            float xExpect = x * f;
            float yExpect = y * f;
            Question1.Vector2 v = new Question1.Vector2(x, y);
            Question1.Vector2 actual = v * f;
            Assert.That(actual.x, Is.EqualTo(xExpect).Within(kEpsilon));
            Assert.That(actual.y, Is.EqualTo(yExpect).Within(kEpsilon));
        }

        [TestCase(-1, -1, 2)]
        [TestCase(0.2f, 0.3f, 4)]
        public void TestOperatorDivide(float x, float y, float f)
        {
            float xExpect = x / f;
            float yExpect = y / f;
            Question1.Vector2 v = new Question1.Vector2(x, y);
            Question1.Vector2 actual = v / f;
            Assert.That(actual.x, Is.EqualTo(xExpect).Within(kEpsilon));
            Assert.That(actual.y, Is.EqualTo(yExpect).Within(kEpsilon));
        }

        [TestCase(-1, -1)]
        [TestCase(0.2f, 0.3f)]
        public void TestOperatorDivide_ZeroDivider(float x, float y)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Question1.Vector2 v = new Question1.Vector2(x, y);
                Question1.Vector2 actual = v / 0;
            });
        }

        public void TestImplicit()
        {
            Question1.Vector3 v3 = new Question1.Vector3(1, 2, 3);
            Question1.Vector2 v2 = v3;
            Assert.AreEqual(v3.x, v2.x);
            Assert.AreEqual(v3.y, v2.y);
        }

        public void TestExplicit()
        {
            Question1.Vector2 v2 = new Question1.Vector2(1, 2);
            Question1.Vector3 v3 = (Question1.Vector3)v2;
            Assert.AreEqual(v2.x, v3.x);
            Assert.AreEqual(v2.y, v3.y);
            Assert.Zero(v3.z);
        }
    }
}
