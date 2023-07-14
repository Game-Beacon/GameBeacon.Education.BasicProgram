using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PG0007.Questions
{
    public interface IFactory<T>
    {
        T Spawn();
    }
}
