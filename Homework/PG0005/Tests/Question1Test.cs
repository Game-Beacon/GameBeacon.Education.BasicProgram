using NUnit.Framework;
using static PG0005.Questions.Question1;

namespace PG0005.Tests
{
    public class Question1Test
    {
        #region -- Basic --
        public const int BasicLevel = 1;
        public const int BasicMaxHp = 100;
        public const int BasicMaxMp = 50;
        public const int BasicPhyAtk = 10;
        public const int BasicPhyDef = 10;
        public const int BasicMagAtk = 5;
        public const int BasicMagDef = 5;
        #endregion

        #region -- Novice --
        public const int NoviceMaxHpGrow = 10;
        public const int NoviceMaxMpGrow = 5;
        public const int NovicePhyAtkGrow = 1;
        #endregion

        #region -- Knight --
        public const int KnightMaxHpGrow = 25;
        public const int KnightMaxMpGrow = 5;
        public const int KnightPhyAtkGrow = 5;
        public const int KnightPhyDefGrow = 3;
        #endregion

        #region -- Magician --
        public const int MagicianMaxHpGrow = 5;
        public const int MagicianMaxMpGrow = 30;
        public const int MagicianMagAtkGrow = 8;
        public const int MagicianMagDefGrow = 3;
        #endregion

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(19)]
        [TestCase(99)]
        public void JobOnLevelUp(int levelUp)
        {
            Job job = new Job("None");
            Character character = new Character();
            for (int i = 0; i < levelUp; i++)
            {
                job.OnLevelUp(character);
            }
            Assert.AreEqual("None", job.Name);
            Assert.AreEqual(BasicLevel + levelUp, character.Level);
            Assert.AreEqual(BasicMaxHp, character.MaxHp);
            Assert.AreEqual(BasicMaxMp, character.MaxMp);
            Assert.AreEqual(BasicPhyAtk, character.PhyAtk);
            Assert.AreEqual(BasicPhyDef, character.PhyDef);
            Assert.AreEqual(BasicMagAtk, character.MagAtk);
            Assert.AreEqual(BasicMagDef, character.MagDef);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(19)]
        [TestCase(99)]
        public void JobOnSelected(int levelUp)
        {
            Job none = new Job("None");
            Job job = new Job("Other");
            Character character = new Character();
            for (int i = 0; i < levelUp; i++)
            {
                none.OnLevelUp(character);
            }
            job.OnSelected(character);
            Assert.AreEqual("Other", job.Name);
            Assert.AreEqual(BasicLevel + levelUp, character.Level);
            Assert.AreEqual(BasicMaxHp, character.MaxHp);
            Assert.AreEqual(BasicMaxMp, character.MaxMp);
            Assert.AreEqual(BasicPhyAtk, character.PhyAtk);
            Assert.AreEqual(BasicPhyDef, character.PhyDef);
            Assert.AreEqual(BasicMagAtk, character.MagAtk);
            Assert.AreEqual(BasicMagDef, character.MagDef);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(19)]
        [TestCase(99)]
        public void NoviceOnLevelUp(int levelUp)
        {
            Job job = new Novice();
            Character character = new Character();
            for (int i = 0;i < levelUp; i++)
            {
                job.OnLevelUp(character);
            }
            Assert.True(job is Novice);
            Assert.AreEqual("Novice", job.Name);
            Assert.AreEqual(BasicLevel + levelUp, character.Level);
            Assert.AreEqual(BasicMaxHp + levelUp * NoviceMaxHpGrow, character.MaxHp);
            Assert.AreEqual(BasicMaxMp + levelUp * NoviceMaxMpGrow, character.MaxMp);
            Assert.AreEqual(BasicPhyAtk + levelUp * NovicePhyAtkGrow, character.PhyAtk);
            Assert.AreEqual(BasicPhyDef, character.PhyDef);
            Assert.AreEqual(BasicMagAtk, character.MagAtk);
            Assert.AreEqual(BasicMagDef, character.MagDef);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(19)]
        [TestCase(99)]
        public void NoviceOnSelected(int levelUp)
        {
            Job none = new Job("None");
            Job job = new Novice();
            Character character = new Character();
            for (int i = 0; i < levelUp; i++)
            {
                none.OnLevelUp(character);
            }
            job.OnSelected(character);
            Assert.True(job is Novice);
            Assert.AreEqual("Novice", job.Name);
            Assert.AreEqual(BasicLevel + levelUp, character.Level);
            Assert.AreEqual(BasicMaxHp + levelUp * NoviceMaxHpGrow, character.MaxHp);
            Assert.AreEqual(BasicMaxMp + levelUp * NoviceMaxMpGrow, character.MaxMp);
            Assert.AreEqual(BasicPhyAtk + levelUp * NovicePhyAtkGrow, character.PhyAtk);
            Assert.AreEqual(BasicPhyDef, character.PhyDef);
            Assert.AreEqual(BasicMagAtk, character.MagAtk);
            Assert.AreEqual(BasicMagDef, character.MagDef);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(19)]
        [TestCase(99)]
        public void KnightOnLevelUp(int levelUp)
        {
            Job job = new Knight();
            Character character = new Character();
            for (int i = 0; i < levelUp; i++)
            {
                job.OnLevelUp(character);
            }
            Assert.True(job is Knight);
            Assert.AreEqual("Knight", job.Name);
            Assert.AreEqual(BasicLevel + levelUp, character.Level);
            Assert.AreEqual(BasicMaxHp + levelUp * KnightMaxHpGrow, character.MaxHp);
            Assert.AreEqual(BasicMaxMp + levelUp * KnightMaxMpGrow, character.MaxMp);
            Assert.AreEqual(BasicPhyAtk + levelUp * KnightPhyAtkGrow, character.PhyAtk);
            Assert.AreEqual(BasicPhyDef + levelUp * KnightPhyDefGrow, character.PhyDef);
            Assert.AreEqual(BasicMagAtk, character.MagAtk);
            Assert.AreEqual(BasicMagDef, character.MagDef);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(19)]
        [TestCase(99)]
        public void KnightOnSelected(int levelUp)
        {
            Job none = new Job("None");
            Job job = new Knight();
            Character character = new Character();
            for (int i = 0; i < levelUp; i++)
            {
                none.OnLevelUp(character);
            }
            job.OnSelected(character);
            Assert.True(job is Knight);
            Assert.AreEqual("Knight", job.Name);
            Assert.AreEqual(BasicLevel + levelUp, character.Level);
            Assert.AreEqual(BasicMaxHp + levelUp * KnightMaxHpGrow, character.MaxHp);
            Assert.AreEqual(BasicMaxMp + levelUp * KnightMaxMpGrow, character.MaxMp);
            Assert.AreEqual(BasicPhyAtk + levelUp * KnightPhyAtkGrow, character.PhyAtk);
            Assert.AreEqual(BasicPhyDef + levelUp * KnightPhyDefGrow, character.PhyDef);
            Assert.AreEqual(BasicMagAtk, character.MagAtk);
            Assert.AreEqual(BasicMagDef, character.MagDef);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(19)]
        [TestCase(99)]
        public void MagicianOnLevelUp(int levelUp)
        {
            Job job = new Magician();
            Character character = new Character();
            for (int i = 0; i < levelUp; i++)
            {
                job.OnLevelUp(character);
            }
            Assert.True(job is Magician);
            Assert.AreEqual("Magician", job.Name);
            Assert.AreEqual(BasicLevel + levelUp, character.Level);
            Assert.AreEqual(BasicMaxHp + levelUp * MagicianMaxHpGrow, character.MaxHp);
            Assert.AreEqual(BasicMaxMp + levelUp * MagicianMaxMpGrow, character.MaxMp);
            Assert.AreEqual(BasicPhyAtk, character.PhyAtk);
            Assert.AreEqual(BasicPhyDef, character.PhyDef);
            Assert.AreEqual(BasicMagAtk + levelUp * MagicianMagAtkGrow, character.MagAtk);
            Assert.AreEqual(BasicMagDef + levelUp * MagicianMagDefGrow, character.MagDef);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(19)]
        [TestCase(99)]
        public void MagicianOnSelected(int levelUp)
        {
            Job none = new Job("None");
            Job job = new Magician();
            Character character = new Character();
            for (int i = 0; i < levelUp; i++)
            {
                none.OnLevelUp(character);
            }
            job.OnSelected(character);
            Assert.True(job is Magician);
            Assert.AreEqual("Magician", job.Name);
            Assert.AreEqual(BasicLevel + levelUp, character.Level);
            Assert.AreEqual(BasicMaxHp + levelUp * MagicianMaxHpGrow, character.MaxHp);
            Assert.AreEqual(BasicMaxMp + levelUp * MagicianMaxMpGrow, character.MaxMp);
            Assert.AreEqual(BasicPhyAtk, character.PhyAtk);
            Assert.AreEqual(BasicPhyDef, character.PhyDef);
            Assert.AreEqual(BasicMagAtk + levelUp * MagicianMagAtkGrow, character.MagAtk);
            Assert.AreEqual(BasicMagDef + levelUp * MagicianMagDefGrow, character.MagDef);
        }
    }
}
