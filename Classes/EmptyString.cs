using System;
namespace ShriSoft.SharedKernel.Classes
{
    /// <summary>
    /// Return object of type string and set it as empty.
    /// This class can be casted to and from string class.
    /// Value for this class can not be null.
    /// </summary>
    public class EmptyString 
    {
        private readonly string value = string.Empty;

        public EmptyString(string stringValue)
        {
            value = stringValue;
        }

        public static explicit operator string(EmptyString emptyString)
        {
            return emptyString.value;
        }

        public static implicit operator EmptyString(string value)
        {
            return new EmptyString(value);
        }
    }
}

