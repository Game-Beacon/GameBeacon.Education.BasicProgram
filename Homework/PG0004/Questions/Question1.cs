using System;

namespace PG0004.Questions
{
    public class Question1
    {
        public struct Vector3
        {
            public float x; public float y; public float z;

            public Vector3(float x, float y, float z)
            {
                this.x = x; this.y = y; this.z = z;
            }
        }

        public struct Vector2
        {
            const float kEpsilon = 1E-05f;
            public float x, y;

            #region -- Constructor --
            public Vector2(float x, float y)
            {
                this.x = x; this.y = y;
            }
            #endregion

            #region -- Operators --
            /// <summary>
            /// Plus two vector
            /// </summary>
            public static Vector2 operator +(Vector2 v1, Vector2 v2)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Subtract two vector
            /// </summary>
            public static Vector2 operator -(Vector2 v1, Vector2 v2)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Multiple vector by float 
            /// </summary>
            public static Vector2 operator *(Vector2 v, float f)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Divide vector by float
            /// </summary>
            /// <returns></returns>
            /// <exception cref="ArgumentException">f is zero</exception>
            public static Vector2 operator /(Vector2 v, float f)
            {
                throw new NotImplementedException();
            }
            #endregion

            #region -- Conversion --
            /// <summary>
            /// Convert Vector3 to Vector2
            /// </summary>
            public static implicit operator Vector2(Vector3 v)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Convert Vector2 to Vector3
            /// </summary>
            /// <param name="v"></param>
            public static explicit operator Vector3(Vector2 v)
            {
                throw new NotImplementedException();
            }
            #endregion

            /// <summary>
            /// Custom my-format string
            /// </summary>
            public override string ToString()
            {
                throw new NotImplementedException();
            }
        }
    }
}
