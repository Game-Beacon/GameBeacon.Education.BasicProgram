using System;
using UnityEngine;

namespace PG0001.Questions
{
    public class Question2 : MonoBehaviour
    {
        /// <summary>
        /// Check if dodge occured
        /// </summary>
        /// <param name="dodgeRate">The dodge rate</param>
        /// <param name="rand">The random value</param>
        /// <returns>Is dodged or not</returns>
        public bool Dodge(float dodgeRate, float rand)
        {
            throw new NotImplementedException("code something here ...");
        }

        /// <summary>
        /// Check if block occured
        /// </summary>
        /// <param name="blockRate">The block rate</param>
        /// <param name="rand">The random value</param>
        /// <returns>Is blocked or not</returns>
        public bool Block(float blockRate, float rand)
        {
            throw new NotImplementedException("code something here ...");
        }

        /// <summary>
        /// Modify attack point if dodge, block, or both occured
        /// </summary>
        /// <param name="atk">The attack point</param>
        /// <param name="dodgeRate">The dodge rate</param>
        /// <param name="blockRate">The block rate</param>
        /// <param name="dodgeRand">The dodge random value</param>
        /// <param name="blockRand">The block random value</param>
        /// <returns>Modified attack point</returns>
        public int Damage(float atk, float dodgeRate, float blockRate, float dodgeRand, float blockRand)
        {
            throw new NotImplementedException("code something here ...");
        }

    }
}
