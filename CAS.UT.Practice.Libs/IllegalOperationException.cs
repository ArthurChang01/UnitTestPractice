using System;

namespace CAS.UT.Practice.Libs
{
    public class IllegalOperationException : Exception
    {
        public IllegalOperationException(string msg)
            : base(msg)
        {
        }
    }
}