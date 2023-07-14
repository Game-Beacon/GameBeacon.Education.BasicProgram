using System;
using System.Collections.Generic;
using UnityEngine;

namespace PG0007.Questions
{
    public class Question1 : MonoBehaviour
    {
        public class Pool<T> : IPool<T>
        {
            protected const int _batchSpawnCount = 32;

            /// <summary>
            /// 產生物件的工廠
            /// </summary>
            protected IFactory<T> _factory { get; }

            /// <summary>
            /// 儲存物件的空間
            /// </summary>
            protected List<T> _storage { get; }

            /// <summary>
            /// 目前儲存的物件數
            /// </summary>
            public int Count { get { throw new NotImplementedException(); } }

            #region -- Constructors --
            public Pool(IFactory<T> factory)
            {
                throw new NotImplementedException();
            }
            #endregion

            /// <summary>
            /// 主動呼叫並建立物件
            /// </summary>
            /// <param name="count">建立的數量</param>
            public void Ready(int count)
            {
                throw new NotImplementedException();
            }

            public void Push(T item)
            {
                throw new NotImplementedException();
            }

            public T Pop()
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// A bullet object
        /// </summary>
        public class Bullet
        {
            public int Id { get; }

            public Bullet(int id)
            {
                Id = id;
            }
        }

        public class BulletFactory : IFactory<Bullet>
        {
            #region -- Constructors --
            public BulletFactory()
            {
                throw new NotImplementedException();
            }
            #endregion

            public Bullet Spawn()
            {
                throw new NotImplementedException();
            }
        }
    }

    public static class PoolExtension
    {
        public static T[] MultiPop<T>(this IPool<T> pool, int count)
        {
            if (pool == null)
                throw new ArgumentNullException("pool is null");
            if (count < 0)
                throw new ArgumentException("count must be greater than zero");
            throw new NotImplementedException();
        }

        public static void MultiPush<T>(this IPool<T> pool, params T[] items)
        {
            if (pool == null)
                throw new ArgumentNullException("pool is null");
            if (items == null)
                return;
            throw new NotImplementedException();
        }
    }
}
