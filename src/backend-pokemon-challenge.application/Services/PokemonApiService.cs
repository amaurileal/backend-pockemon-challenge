using backend_pokemon_challenge.application.Services.Dtos;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Text.Json;

namespace backend_pokemon_challenge.application.Services
{
    public class PokemonApiService : IPokemonApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public PokemonApiService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public Task<PokemonDto> GetPokemonAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PokemonDto>> GetPokemonsAsync(int limit, int offset)
        {
            // URL do endpoint que retorna a lista de PokemonDto
            var url = _configuration["UrlPokemonOficial"]+ $"pokemon?limit={limit}&offset={offset}"; // substitua pelo URL real

            // Fazendo a requisição HTTP GET
            var response = await _httpClient.GetAsync(url);

            // Assegurando que a resposta foi bem sucedida
            response.EnsureSuccessStatusCode();

            // Lendo o conteúdo da resposta como string
            var responseContent = await response.Content.ReadAsStringAsync();

            // Desserializando o JSON em uma lista de PokemonDto
            var pokemonsResponse = JsonSerializer.Deserialize<PokemonApiResponse>(responseContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return pokemonsResponse.Results;
        }
    }
}
