using System;

namespace ShriSoft.SharedKernel.Classes
{
    /// <summary>
    /// This class will return UTC date time.
    /// This class can be casted to and from datetime class.
    /// Value for this class can not be null.
    /// </summary>
    public class UTCDateTime
    {
        private readonly DateTime value;

        public UTCDateTime(DateTime dateTime)
        {
            value = dateTime;
        }
        public UTCDateTime()
        {
            value = DateTime.UtcNow;
        }
        public static explicit operator DateTime(UTCDateTime utcDateTime)
        {
            return utcDateTime.value;
        }
        public static implicit operator UTCDateTime(DateTime dateTime)
        {
            return new UTCDateTime(dateTime);
        }
    }
}

