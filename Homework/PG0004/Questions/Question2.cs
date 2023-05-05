
using System;
using System.Linq.Expressions;

namespace PG0004.Questions
{
    public class Question2
    {
        public struct Matrix3x3
        {
            /// <summary>
            /// Inner matrix
            /// </summary>
            private float[,] _matrix;

            #region -- Properties --
            public float m00
            {
                get { return _matrix[0, 0]; }
                set { _matrix[0, 0] = value; }
            }

            public float m01
            {
                get { return _matrix[0, 1]; }
                set { _matrix[0, 1] = value; }
            }

            public float m02
            {
                get { return _matrix[0, 2]; }
                set { _matrix[0, 2] = value; }
            }

            public float m10
            {
                get { return _matrix[1, 0]; }
                set { _matrix[1, 0] = value; }
            }

            public float m11
            {
                get { return _matrix[1, 1]; }
                set { _matrix[1, 1] = value; }
            }

            public float m12
            {
                get { return _matrix[1, 2]; }
                set { _matrix[1, 2] = value; }
            }

            public float m20
            {
                get { return _matrix[2, 0]; }
                set { _matrix[2, 0] = value; }
            }

            public float m21
            {
                get { return _matrix[2, 1]; }
                set { _matrix[2, 1] = value; }
            }

            public float m22
            {
                get { return _matrix[2, 2]; }
                set { _matrix[2, 2] = value; }
            }
            #endregion

            /// <summary>
            /// Get/Set an element by 1D-Index
            /// </summary>
            public float this[int index]
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            /// <summary>
            /// Get/Set an element by row and colomn
            /// </summary>
            public float this[int row, int col]
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            #region -- Constructors --
            public Matrix3x3(params float[] array)
            {
                if (array == null || array.Length != 9)
                {
                    throw new ArgumentException("Array length must be equal to 9");
                }
                _matrix = new float[3, 3];
                for (int i = 0; i < array.Length; i++)
                {
                    _matrix[i / 3, i % 3] = array[i];
                }
            }

            public Matrix3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
            {
                _matrix = new float[,]
                {
                    {m00, m01, m02 },
                    {m10, m11, m12 },
                    {m20, m21, m22 },
                };
            }
            #endregion

            /// <summary>
            /// Parse matrix into 2D-Array
            /// </summary>
            /// <returns>Parsed 2D-Array</returns>
            public float[,] To2DArray()
            {
                throw new NotImplementedException();
            }
        }
    }
}
