using System;

namespace PG0005.Questions
{
    public class Question1
    {
        public class Job
        {
            public string Name { get; }

            #region -- Constructor --
            public Job(string name)
            {
                /* �~�ӮɡA�O�o�ŧi�غc�l�ê����g�J¾�~�W�� */
                Name = name;
            }
            #endregion

            /// <summary>
            /// Call on level up, fix the properties of the character
            /// </summary>
            /// <param name="character">the characher will be fixed</param>
            /// <exception cref="ArgumentNullException">character is null</exception>
            /// <exception cref="ArgumentException">character level is highest</exception>
            public virtual void OnLevelUp(Character character)
            {
                if (character == null)
                {
                    throw new ArgumentNullException("character is null");
                }
                if (character.Level + 1 > 100)
                {
                    throw new ArgumentException("character level is highest");
                }
                throw new NotImplementedException();
            }

            /// <summary>
            /// Call on job selected, fix the properties of the character
            /// </summary>
            /// <param name="character">the character will be fixed</param>
            /// <exception cref="ArgumentNullException">character is null</exception>
            public virtual void OnSelected(Character character)
            {
                if (character == null)
                {
                    throw new ArgumentNullException("character is null");
                }
                throw new NotImplementedException();
            }
        }

        public class Novice
        {
            public void OnLevelUp(Character character) { throw new NotImplementedException(); }

            public void OnSelected(Character character) { throw new NotImplementedException(); }
        }

        public class Knight
        {
            public void OnLevelUp(Character character) { throw new NotImplementedException(); }

            public void OnSelected(Character character) { throw new NotImplementedException(); }
        }

        public class Magician
        {
            public void OnLevelUp(Character character) { throw new NotImplementedException(); }

            public void OnSelected(Character character) { throw new NotImplementedException(); }
        }

        public class Character
        {
            public int Level;
            public int MaxHp, MaxMp;
            public int PhyAtk, PhyDef;
            public int MagAtk, MagDef;
        }
    }
}
