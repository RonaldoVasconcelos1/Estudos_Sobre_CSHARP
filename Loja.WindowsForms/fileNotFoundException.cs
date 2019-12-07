using System;
using System.Runtime.Serialization;

namespace Loja.WindowsForms
{
    [Serializable]
    internal class fileNotFoundException : Exception
    {
        public fileNotFoundException()
        {
        }

        public fileNotFoundException(string message) : base(message)
        {
        }

        public fileNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected fileNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}