using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PG0007.Questions
{
    public interface IPool<T>
    {
        void Push(T item);

        T Pop();
    }
}
