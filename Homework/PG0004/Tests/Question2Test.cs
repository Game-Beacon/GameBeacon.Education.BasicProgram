
using NUnit.Framework;
using PG0004.Questions;
using System;

namespace PG0004.Tests
{
    public class Question2Test
    {
        [Test]
        public void TestMatrix3x3Indexer()
        {
            var nums = new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var m = new Question2.Matrix3x3(nums);
            for(int i = 0; i < nums.Length; i++) 
            {
                Assert.AreEqual(nums[i], m[i]);
            }
        }

        [Test]
        public void TestMatrix4x4Indexer2D()
        {
            var nums = new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var m = new Question2.Matrix3x3(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Assert.AreEqual(nums[i], m[i / 3, i % 3]);
            }
        }

        [Test] 
        public void TestMatrixTo2DArray()
        {
            var m = new Question2.Matrix3x3(1, 2, 3, 4, 5, 6, 7, 8, 9);
            var arr2D = m.To2DArray();
            for (int r = 0; r < arr2D.GetLength(0); r++)
            {
                for (int c = 0; c < arr2D.GetLength(1); c++)
                {
                    arr2D[r, c]++;
                }
            }
            for (int r = 0; r < arr2D.GetLength(0); r++)
            {
                for (int c = 0; c < arr2D.GetLength(1); c++)
                {
                    Assert.AreNotEqual(m[r, c], arr2D[r, c]);
                }
            }
        }
    }
}
