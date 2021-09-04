using System;

namespace _07.MilitaryElite.Exceptions
{
    public class InvalidMissionStateExeption : Exception
    {
        private const string DEF_EXC_MSG = "Invalid mission state";
        public InvalidMissionStateExeption():base(DEF_EXC_MSG)
        {

        }

        public InvalidMissionStateExeption(string message)
            : base(message)
        {

        }
    }
}
