namespace backend_pokemon_challenge.domain.Exceptions
{
    public class NotFoundException(string resourceType, string resourceIdentifier)
        : Exception($"{resourceType} with id: {resourceIdentifier} doesn't exists")
    {
    }
}
