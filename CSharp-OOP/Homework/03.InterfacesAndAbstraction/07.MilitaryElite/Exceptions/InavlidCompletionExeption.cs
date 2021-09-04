using System;

namespace _07.MilitaryElite.Exceptions
{
    public class InavlidCompletionExeption : Exception
    {
        private const string DEF_EXS_MSG = "Mission alredy completed!";
        public InavlidCompletionExeption()
        {
        }

        public InavlidCompletionExeption(string message) : base(message)
        {
        }
    }
}
