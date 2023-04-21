using System;

namespace PG0003.Questions
{
    public class Question1
    {
        public struct Vector2
        {
            /// <summary>
            /// The tolerance of the float value
            /// </summary>
            private const float kEpsilon = 1E-05f;

            #region -- Constant Vectors --
            public static readonly Vector2 Zero = new Vector2(0, 0);
            public static readonly Vector2 One = new Vector2(1, 1);
            public static readonly Vector2 Left = new Vector2(-1, 0);
            public static readonly Vector2 Right = new Vector2(1, 0);
            public static readonly Vector2 Up = new Vector2(0, 1);
            public static readonly Vector2 Down = new Vector2(0, -1);
            #endregion

            /// <summary>
            /// x-axis
            /// </summary>
            public float x;

            /// <summary>
            /// y-axis
            /// </summary>
            public float y;

            /// <summary>
            /// Length of vector
            /// </summary>
            public float magnitude { get; }

            #region -- Constructor --
            /// <summary>
            /// Constructor for newing vector
            /// </summary>
            /// <param name="x">init x-axis</param>
            /// <param name="y">init y-axis</param>
            public Vector2(float x, float y)
            {
                throw new NotImplementedException();
            }
            #endregion

            /// <summary>
            /// Normalize current vector
            /// </summary>
            public void Normalize()
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Calculate current length of vector
            /// </summary>
            /// <returns>length of vector</returns>
            public float Magnitude()
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Revert current vector
            /// </summary>
            public void Negative()
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Add other vector
            /// </summary>
            public void Add(Vector2 v)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Subtract other vector
            /// </summary>
            public void Subtract(Vector2 v)
            {
                throw new NotImplementedException();
            }

            #region -- Static Methods --
            /// <summary>
            /// Normalize specific vector
            /// </summary>
            /// <param name="v">the specific vector to normalize</param>
            /// <returns>Normalized vector</returns>
            public static Vector2 Normalize(Vector2 v)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Calculate distence between vectors
            /// </summary>
            /// <param name="from">the start vector</param>
            /// <param name="to">the end vector</param>
            /// <returns>Distance between from and to vectors</returns>
            public static float Distance(Vector2 from, Vector2 to)
            {
                throw new NotImplementedException();
            }
            #endregion
        }
    }
}
