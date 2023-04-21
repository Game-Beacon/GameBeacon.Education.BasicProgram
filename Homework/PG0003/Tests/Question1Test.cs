using System;
using NUnit.Framework;
using PG0003.Questions;

namespace PG0003.Tests
{
    public class Question1Test
    {
        private const float kEpsilon = 1E-05f;

        [TestCase(-1, -2)]
        [TestCase(0, 0)]
        [TestCase(1, 2)]
        public void TestConstructor(float x, float y)
        {
            Question1.Vector2 v = new Question1.Vector2(x, y);
            Assert.That(v.x, Is.EqualTo(x).Within(kEpsilon));
            Assert.That(v.y, Is.EqualTo(y).Within(kEpsilon));
        }

        [TestCase(0, 0)]
        [TestCase(3, 4)]
        [TestCase(7, 24)]
        public void TestMagnitudeProperty(float x, float y)
        {
            Question1.Vector2 v = new Question1.Vector2(x, y);
            Assert.That(v.magnitude * v.magnitude, Is.EqualTo(x * x + y * y).Within(kEpsilon));
        }

        [TestCase(0, 0)]
        [TestCase(3, 4)]
        [TestCase(7, 24)]
        public void TestMagnitudeMethod(float x, float y)
        {
            Question1.Vector2 v = new Question1.Vector2(x, y);
            var magnitude = v.Magnitude();
            Assert.That(magnitude * magnitude, Is.EqualTo(x * x + y * y).Within(kEpsilon));
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(-1, 1)]
        [TestCase(1, -1)]
        public void TestNegativeMethod(float x, float y)
        {
            Question1.Vector2 v= new Question1.Vector2(x, y);
            v.Negative();
            Assert.That(v.x, Is.EqualTo(-x).Within(kEpsilon));
            Assert.That(v.y, Is.EqualTo(-y).Within(kEpsilon));
        }

        [TestCase(0, 0, 0, 0)]
        [TestCase(1, 2, 3, 4)]
        [TestCase(2, -2, -2, 2)]
        public void TestAddMethod(float x1, float y1, float x2, float y2)
        {
            Question1.Vector2 v1 = new Question1.Vector2(x1, y1);
            Question1.Vector2 v2 = new Question1.Vector2(x2, y2);
            v1.Add(v2);
            Assert.That(v1.x, Is.EqualTo(x1 + x2).Within(kEpsilon));
            Assert.That(v1.y, Is.EqualTo(y1 + y2).Within(kEpsilon));

            Assert.That(v2.x, Is.EqualTo(x2).Within(kEpsilon));
            Assert.That(v2.y, Is.EqualTo(y2).Within(kEpsilon));
        }

        [TestCase(0, 0, 0, 0)]
        [TestCase(1, 2, 3, 4)]  
        [TestCase(2, -2, -2, 2)]
        public void TestSubtraceMethod(float x1, float y1, float x2, float y2)
        {
            Question1.Vector2 v1 = new Question1.Vector2(x1, y1);
            Question1.Vector2 v2 = new Question1.Vector2(x2, y2);
            v1.Subtract(v2);
            Assert.That(v1.x, Is.EqualTo(x1 - x2).Within(kEpsilon));
            Assert.That(v1.y, Is.EqualTo(y1 - y2).Within(kEpsilon));

            Assert.That(v2.x, Is.EqualTo(x2).Within(kEpsilon));
            Assert.That(v2.y, Is.EqualTo(y2).Within(kEpsilon));
        }

        [TestCase(3, 4)]
        [TestCase(4, 3)]
        [TestCase(7, 24)]
        [TestCase(24, 7)]
        public void TestNormalizeMethod(float x, float y)
        {
            float len = (float)Math.Sqrt(x * x + y * y);
            Question1.Vector2 v = new Question1.Vector2(x, y);
            v.Normalize();
            Assert.That(v.x, Is.EqualTo(x / len).Within(kEpsilon));
            Assert.That(v.y, Is.EqualTo(y / len).Within(kEpsilon));
        }

        [TestCase(3, 4)]
        [TestCase(4, 3)]
        [TestCase(7, 24)]
        [TestCase(24, 7)]
        public void TestStaticNormalizeMethod(float x, float y)
        {
            float len = (float)Math.Sqrt(x * x + y * y);
            Question1.Vector2 v = new Question1.Vector2(x, y);
            Question1.Vector2 normalized = Question1.Vector2.Normalize(v);
            Assert.That(normalized.x, Is.EqualTo(x / len).Within(kEpsilon));
            Assert.That(normalized.y, Is.EqualTo(y / len).Within(kEpsilon));
        }


        [TestCase(0, 0, 0, 0, 0)]
        [TestCase(3, -5, -1, -2, 5)]
        [TestCase(0, 0, 7, 24, 25)]
        public void TestStaticDistanceMethod(float x1, float y1, float x2, float y2, float expected)
        {
            float distance = Question1.Vector2.Distance(new Question1.Vector2(x1, y1), new Question1.Vector2(x2, y2));
            Assert.That(distance, Is.EqualTo(expected).Within(kEpsilon));
        }
    }
}
