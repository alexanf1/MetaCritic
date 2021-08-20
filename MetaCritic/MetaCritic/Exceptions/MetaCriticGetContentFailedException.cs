
namespace MetaCritic.Exceptions
{
    using System;

    public class MetaCriticGetContentFailedException : Exception
    {
        public MetaCriticGetContentFailedException()
        {
        }

        public MetaCriticGetContentFailedException(string message)
            : base(message)
        {
        }

        public MetaCriticGetContentFailedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
