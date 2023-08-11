using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PG0008.Questions
{
    public interface IRandom
    {
        float Next();
    }

    public class DamageCalculator
    {
        private IRandom _rand;

        public DamageCalculator(IRandom rand) {  _rand = rand; }

        public int Damage(int atk, float critRate)
        {
            if (critRate < 0)
            {
                throw new ArgumentException("invalid critical rate");
            }
            float dmg = atk;
            if (_rand.Next() <= critRate && critRate > 0)
            {
                dmg *= 1.5f;
            }
            if (dmg < 0)
            {
                dmg = 0;
            }
            return (int)dmg;
        }
    }


}
