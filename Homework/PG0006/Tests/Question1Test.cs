using System;
using NUnit.Framework;
using static PG0006.Questions.Question1;

namespace PG0006.Tests
{
    public class Question1Test
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void TestBotConstructor(int ap)
        {
            var bot = new Bot(ap);
            Assert.AreEqual(ap, bot.ActionPoint);
        }

        [Test]
        public void TestBotAddRecord()
        {
            var bot = new Bot(0);
            for (int i = 0; i < 10; i++)
            {
                bot.AddRecord($"{i}");
            }
            CollectionAssert.AreEqual(new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }, bot.GetRecords());
        }

        [Test]
        public void TestFsmConstructor_NullTarget()
        {
            Assert.Catch<ArgumentNullException>(() =>
            {
                _ = new FiniteStateMachine(null);
            });
        }

        [Test]
        public void TestFsmConstructor_NotNullTarget()
        {
            var bot = new Bot(5);
            var fsm = new FiniteStateMachine(bot);
            Assert.AreEqual(bot, fsm.Target);
        }

        [Test]
        public void TestFsmSetState_NullState()
        {
            var bot = new Bot(5);
            var fsm = new FiniteStateMachine(bot);
            Assert.Catch<ArgumentNullException>(() =>
            {
                fsm.SetState(null);
            });
        }

        [Test]
        public void TestFsmSetState()
        {
            var bot = new Bot(5);
            var fsm = new FiniteStateMachine(bot);
            var state = new IdleState();
            fsm.SetState(state);
            Assert.AreEqual(state, fsm.CurrentState);
        }

        [Test]
        public void TestRecords_SufficientAP()
        {
            Bot bot = new Bot(4);               // spawn with specific AP
            IState[] states = new IState[] {
                new WalkState(),
                new AttackState(),
                new JumpState(),
                new IdleState(),
            };

            FiniteStateMachine fsm = new FiniteStateMachine(bot);
            foreach (var state in states)
            {
                fsm.SetState(state);
            }

            CollectionAssert.AreEqual(new string[]{
                "Enter (Walk)",
                "Exit (Walk)",
                "Enter (Attack)",
                "Exit (Attack)",
                "Enter (Jump)",
                "Exit (Jump)",
                "Enter (Idle)",
            }, bot.GetRecords());
        }

        [Test]
        public void TestRecords_InsufficiantAP()
        {
            Bot bot = new Bot(3);               // spawn with specific AP
            IState[] states = new IState[] {
                new WalkState(),
                new AttackState(),
                new JumpState(),
                new IdleState(),
            };

            FiniteStateMachine fsm = new FiniteStateMachine(bot);
            foreach (var state in states)
            {
                fsm.SetState(state);
            }

            CollectionAssert.AreEqual(new string[]{
                "Enter (Walk)",
                "Exit (Walk)",
                "Enter (Attack)",
                "Exit (Attack)",
                "Enter (Idle)",
            }, bot.GetRecords());
        }

        [Test]
        public void TestIdleState()
        {
            var bot = new Bot(3);
            var fsm = new FiniteStateMachine(bot);
            var state = new IdleState();
            Assert.IsTrue(state.CanEnter(fsm));
            Assert.DoesNotThrow(() => { state.OnEnter(fsm); });
            Assert.DoesNotThrow(() => { state.OnExit(fsm); });
        }

        [Test]
        public void TestIdleState_NullFsm()
        {
            var bot = new Bot(3);
            var state = new IdleState();
            Assert.Catch<ArgumentNullException>(() => state.CanEnter(null));
            Assert.Catch<ArgumentNullException>(() => state.OnEnter(null));
            Assert.Catch<ArgumentNullException>(() => { state.OnExit(null); });
        }

        [TestCase(1)]
        [TestCase(0)]
        public void TestWalkState(int ap)
        {
            var bot = new Bot(ap);
            var fsm = new FiniteStateMachine(bot);
            var state = new WalkState();
            Assert.AreEqual(ap >= 1, state.CanEnter(fsm));
            Assert.DoesNotThrow(() => { state.OnEnter(fsm); });
            Assert.DoesNotThrow(() => { state.OnExit(fsm); });
            Assert.AreEqual(ap-1, bot.ActionPoint);
        }

        [Test]
        public void TestWalkState_NullFsm()
        {
            var bot = new Bot(3);
            var state = new IdleState();
            Assert.Catch<ArgumentNullException>(() => state.CanEnter(null));
            Assert.Catch<ArgumentNullException>(() => state.OnEnter(null));
            Assert.Catch<ArgumentNullException>(() => { state.OnExit(null); });
        }

        [TestCase(1)]
        [TestCase(0)]
        public void TestJumpState(int ap)
        {
            var bot = new Bot(ap);
            var fsm = new FiniteStateMachine(bot);
            var state = new JumpState();
            Assert.AreEqual(ap >= 1, state.CanEnter(fsm));
            Assert.DoesNotThrow(() => { state.OnEnter(fsm); });
            Assert.DoesNotThrow(() => { state.OnExit(fsm); });
            Assert.AreEqual(ap - 1, bot.ActionPoint);
        }

        [Test]
        public void TestJumpState_NullFsm()
        {
            var bot = new Bot(3);
            var state = new JumpState();
            Assert.Catch<ArgumentNullException>(() => state.CanEnter(null));
            Assert.Catch<ArgumentNullException>(() => state.OnEnter(null));
            Assert.Catch<ArgumentNullException>(() => { state.OnExit(null); });
        }

        [TestCase(2)]
        [TestCase(0)]
        public void TestAttackState(int ap)
        {
            var bot = new Bot(ap);
            var fsm = new FiniteStateMachine(bot);
            var state = new AttackState();
            Assert.AreEqual(ap >= 2, state.CanEnter(fsm));
            Assert.DoesNotThrow(() => { state.OnEnter(fsm); });
            Assert.DoesNotThrow(() => { state.OnExit(fsm); });
            Assert.AreEqual(ap - 2, bot.ActionPoint);
        }

        [Test]
        public void TestAttackState_NullFsm()
        {
            var bot = new Bot(3);
            var state = new AttackState();
            Assert.Catch<ArgumentNullException>(() => state.CanEnter(null));
            Assert.Catch<ArgumentNullException>(() => state.OnEnter(null));
            Assert.Catch<ArgumentNullException>(() => { state.OnExit(null); });
        }
    }
}
