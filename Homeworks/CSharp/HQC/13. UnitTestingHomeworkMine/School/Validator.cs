namespace School
{
    using System;

    internal class Validator
    {
        internal static bool ValidateName(string name)
        {
            bool isNameValid = string.IsNullOrWhiteSpace(name);
            return isNameValid;
        }

        internal static bool ValidateUniqueNumber(int uniqueNumber, int min, int max)
        {
            bool isUniqueNumberValid = uniqueNumber >= min && uniqueNumber <= max;
            return isUniqueNumberValid;
        }
    }
}