using System;
using System.Runtime.Serialization;

namespace ExercicioException
{
    [Serializable]
    internal class Accountexception : Exception
    {
        public Accountexception()
        {
        }

        public Accountexception(string message) : base(message)
        {
        }

        public Accountexception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Accountexception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}