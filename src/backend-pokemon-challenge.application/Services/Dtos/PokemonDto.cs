namespace backend_pokemon_challenge.application.Services.Dtos
{
    public class PokemonDto
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class PokemonApiResponse
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<PokemonDto> Results { get; set; }
    }
}
