using System;
using _06.Telephony.Common;
using _06.Telephony.Contract;

namespace _06.Telephony.Model
{
    public class Smartphone : IBrowsing, ICallable
    {

        public string Browsing(string site)
        {
            if (Validator.IsSiteValid(site))
            {
                throw new InvalidOperationException(String.Format(Validator.INVALID_SITE));
            }

            return $"Browsing: {site}!";
        }

        public string Calling(string number)
        {
            if (!Validator.IsNumberValid(number))
            {
                throw new InvalidOperationException(String.Format(Validator.INVALID_NUMBER));
            }

            return $"Calling... {number}";
        }
    }
}
