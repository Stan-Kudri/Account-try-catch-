using System.Runtime.Serialization;

namespace AccountTryCatch
{
    [Serializable]
    internal class WrongLoginException : Exception
    {
        public WrongLoginException()
        {
        }

        public WrongLoginException(string? message) : base(message)
        {
        }

        public WrongLoginException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected WrongLoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}