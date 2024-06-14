namespace backend_pokemon_challenge.domain.Exceptions;

public class BadRequestException(string message) : Exception(message)
{
}