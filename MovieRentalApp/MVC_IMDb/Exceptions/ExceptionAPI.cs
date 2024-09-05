using System;

namespace MVC_IMDb.Exceptions
{
    public class ExceptionAPI : Exception
    {
        public ExceptionAPI(string message) : base(message)
        {
        }

        public static void ThrowGetMoviesListException(int statusCode)
        {
            string errorMessage = $"Erro ao obter a lista de filmes. Código de status: {statusCode}";
            throw new ExceptionAPI(errorMessage);
        }

        public static void ThrowGetMovieDetailsException(int statusCode)
        {
            string errorMessage = $"Erro ao obter detalhes do filme. Código de status: {statusCode}";
            throw new ExceptionAPI(errorMessage);
        }
    }
}
