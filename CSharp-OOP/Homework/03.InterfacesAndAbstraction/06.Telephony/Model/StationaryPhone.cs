using System;
using _06.Telephony.Common;
using _06.Telephony.Contract;

namespace _06.Telephony.Model
{
    public class StationaryPhone : ICallable
    {
        public string Calling(string number)
        {
            if (!Validator.IsNumberValid(number))
            {
                throw new InvalidOperationException(String.Format(Validator.INVALID_NUMBER));
            }

            return $"Dialing... {number}";
        }
    }
}
