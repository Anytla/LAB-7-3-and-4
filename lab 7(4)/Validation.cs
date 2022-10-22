using System;
using System.Linq;

namespace Telephony
{
    public static class Validator
    {
        public static void ValidateNotNull(string value, string type)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{type} cannot be null");
            }
        }

        public static void ValidatePhoneNumber(string number)
        {
            if (number.Any(x => char.IsLetter(x)) || number.Any(x => char.IsWhiteSpace(x)))
            {
                throw new ArgumentException("Invalid number!");
            }
        }

        public static void ValidateUrl(string url)
        {
            if (url.Any(x => char.IsDigit(x)) || url.Any(x => char.IsWhiteSpace(x)))
            {
                throw new ArgumentException("Invalid URL!");
            }
        }
    }

    public class Smartphone : ICaller, IBrowser
    {
        public string Browse(string url)
        {
            Validator.ValidateUrl(url);

            return $"Browsing... {url}";
        }

        public string Call(string number)
        {
            Validator.ValidatePhoneNumber(number);

            return $"Calling... {number}";
        }
    }

}