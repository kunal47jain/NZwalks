using System.Runtime.Serialization;

namespace Crudoperation.Controllers
{
    [Serializable]
    internal class DbUontextConcurrencyException : Exception
    {
        public DbUontextConcurrencyException()
        {
        }

        public DbUontextConcurrencyException(string? message) : base(message)
        {
        }

        public DbUontextConcurrencyException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DbUontextConcurrencyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}