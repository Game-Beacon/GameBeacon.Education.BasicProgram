using System;
using System.Collections.Generic;

namespace PG0006.Questions
{
    public class Question1
    {
        /// <summary>
        /// A state for finite state machine
        /// </summary>
        public interface IState
        {
            /// <summary>
            /// Check if the state can be entered
            /// </summary>
            /// <returns>enterable</returns>
            bool CanEnter(FiniteStateMachine fsm);
            /// <summary>
            /// Enter the state
            /// </summary>
            void OnEnter(FiniteStateMachine fsm);
            /// <summary>
            /// Exit the state
            /// </summary>
            /// <param name="fsm"></param>
            void OnExit(FiniteStateMachine fsm);
        }

        /// <summary>
        /// Finite state machine
        /// </summary>
        public class FiniteStateMachine
        {
            /// <summary>
            /// The target of model
            /// </summary>
            public object Target { get; }

            /// <summary>
            /// The current state of machine
            /// </summary>
            public IState CurrentState { get; private set; }

            #region -- Constructor --
            public FiniteStateMachine(object target)
            {
                if (target == null)
                    throw new ArgumentNullException("target is null");
                Target = target;
            }
            #endregion

            /// <summary>
            /// Exit current state and enter next state
            /// </summary>
            /// <exception cref="ArgumentNullException">if the specific state is null</exception>
            public void SetState(IState state)
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// The bot
        /// </summary>
        public class Bot
        {
            /// <summary>
            /// Action Point for bot activity consuming
            /// </summary>
            public int ActionPoint { get; }

            /// <summary>
            /// The records of bot activities
            /// </summary>
            private List<string> _records = new List<string>();

            #region -- Constructor --
            public Bot(int actionPoint)
            {
                throw new NotImplementedException();
            }
            #endregion

            /// <summary>
            /// Add record into bot
            /// </summary>
            public void AddRecord(string record)
            {
                _records.Add(record);
            }

            /// <summary>
            /// Get records of bot activities
            /// </summary>
            /// <returns></returns>
            public string[] GetRecords()
            {
                return _records.ToArray();
            }

            /// <summary>
            /// Consume ap for activity
            /// </summary>
            /// <exception cref="ArgumentOutOfRangeException">ap must be greater than zero</exception>
            public void ConsumeAP(int ap)
            {
                if (ap < 0)
                    throw new ArgumentOutOfRangeException("consumed ap must be greater than zero");
                throw new NotImplementedException();
            }

            /// <summary>
            /// Recovery ap 
            /// </summary>
            /// <exception cref="ArgumentOutOfRangeException">ap must be greater than zero</exception>
            public void RecoveryAP(int ap)
            {
                if (ap < 0)
                    throw new ArgumentOutOfRangeException("added ap must be greater than zero");
                throw new NotImplementedException();
            }
        }
    }
}
