
namespace MetaCritic.Exceptions
{
    using System;

    public class MetaCriticInvalidGameException : Exception
    {
        public MetaCriticInvalidGameException()
        {
        }

        public MetaCriticInvalidGameException(string message)
            : base(message)
        {
        }

        public MetaCriticInvalidGameException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
