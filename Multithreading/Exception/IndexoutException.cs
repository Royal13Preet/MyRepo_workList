using System;
using System.Runtime.Serialization;

namespace Exception
{
    [Serializable]
    internal class IndexoutException : System.Exception
    {
        public IndexoutException()
        {
        }

        public IndexoutException(string message) : base(message)
        {
        }

        public IndexoutException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected IndexoutException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}