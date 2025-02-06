using System;
using System.Runtime.Serialization;

namespace Exception
{
    [Serializable]
    internal class exception : System.Exception
    {
        public exception()
        {
        }

        public exception(string message) : base(message)
        {
        }

        public exception(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected exception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}