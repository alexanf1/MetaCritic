using System;

namespace MetaCritic.Exceptions
{
    public class MetaCriticInvalidDocument : Exception
    {
        public MetaCriticInvalidDocument()
        {
        }

        public MetaCriticInvalidDocument(string message)
            : base(message)
        {
        }

        public MetaCriticInvalidDocument(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
