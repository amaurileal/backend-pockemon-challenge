using AutoMapper;
using backend_pokemon_challenge.application.Services;
using backend_pokemon_challenge.application.Services.Dtos;
using MediatR;
using Microsoft.Extensions.Logging;

namespace backend_pokemon_challenge.application.Pokemons.Queries.GetPokemons
{
    public class GetPokemonsQueryHandler(
        IPokemonApiService service,
        ILogger<GetPokemonsQueryHandler> logger,
        IMapper mapper
        ) : IRequestHandler<GetPokemonsQuery, IEnumerable<PokemonDto>>
    {
        public async Task<IEnumerable<PokemonDto>> Handle(GetPokemonsQuery request, CancellationToken cancellationToken)
        {
            return await service.GetPokemonsAsync(request.Limit, request.Offset);
        }
    }
}
