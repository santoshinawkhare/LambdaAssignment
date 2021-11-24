using System;
using System.Collections.Generic;
using System.Text;

namespace Day_24_Assign_lambda
{
    public class CheckCustomExceptionPattern : Exception
    {
        public enum ExceptionType
        {
            ENTERED_INVALIDFIRSTNAME,
            ENTERED_INVALIDLASTNAME,
            ENTERED_INVALIDEMAIL,
            ENTERED_INVALIDMOBILE,
            ENTERED_INVALIDPASSWORD
        }
        ExceptionType type;
        public CheckCustomExceptionPattern(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
