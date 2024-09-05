using System;

namespace MVC_IMDb.Exceptions
{
    public class ExceptionUser : Exception
    {
        public ExceptionUser(string message) : base(message)
        {
        }

        public static void ThrowUserNotFoundException(int UserId)
        {
            string errorMessage = $"Utilizador não encontrado: {UserId}";
            throw new ExceptionUser(errorMessage);
        }

        public static void ThrowGetUserErrorException(int UserId)
        {
            string errorMessage = $"Erro ao obter utilizador: {UserId}";
            throw new ExceptionUser(errorMessage);
        }
    }
}
