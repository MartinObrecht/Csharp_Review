using System;


namespace ExercicioException.Entities.Exceptions
{
    class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message)
        {
        }

    }
}
