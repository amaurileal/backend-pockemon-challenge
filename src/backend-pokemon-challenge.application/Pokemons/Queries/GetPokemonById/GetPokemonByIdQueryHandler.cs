using AutoMapper;
using backend_pokemon_challenge.application.Services;
using backend_pokemon_challenge.application.Services.Dtos;
using MediatR;
using Microsoft.Extensions.Logging;

namespace backend_pokemon_challenge.application.Pokemons.Queries.GetPokemonById
{
    public class GetPokemonByIdQueryHandler(
        IPokemonApiService service,
        ILogger<GetPokemonByIdQueryHandler> logger,
        IMapper mapper
        ) : IRequestHandler<GetPokemonByIdQuery, PokemonDto>
    {
        public Task<PokemonDto> Handle(GetPokemonByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
