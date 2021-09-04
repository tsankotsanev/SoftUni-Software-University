using System;
using _07.MilitaryElite.Contracts;
using _07.MilitaryElite.Enumerations;
using _07.MilitaryElite.Exceptions;

namespace _07.MilitaryElite.Models
{
    public class Mission : IMission
    {
        public Mission(string coldName, string state)
        {
            CodeName = coldName;
            State = TryParseState(state);
        }

        public string CodeName { get; }

        public State State { get; private set; }

        public void CompleteMission()
        {
            if (State == State.Finished)
            {
                throw new InavlidCompletionExeption();

            }

            State = State.Finished;
        }
        private State TryParseState(string stateStr)
        {
            State state;
            var parsed = Enum.TryParse(stateStr, out state);

            if (!parsed)
            {
                throw new InvalidMissionStateExeption();
            }
            return state;
        }
        public override string ToString()
        {
            return $"  Code Name: {CodeName} State: {State}";
        }
    }
}
