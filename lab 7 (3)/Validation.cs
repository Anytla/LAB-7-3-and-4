using System;
namespace Ferrari
{
    public static class Validation
    {
        public static void ValidateIsNull(string value, string type)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{type} cannot be empty");
            }
        }
    }
}