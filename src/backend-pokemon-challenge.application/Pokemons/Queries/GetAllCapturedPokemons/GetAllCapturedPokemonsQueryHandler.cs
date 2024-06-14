using AutoMapper;
using backend_pokemon_challenge.application.Services.Dtos;
using backend_pokemon_challenge.domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_pokemon_challenge.application.Pokemons.Queries.GetAllCapturedPokemons
{
    public class GetAllCapturedPokemonsQueryHandler(
        ICapturedPokemonRepository repository,
        ILogger<GetAllCapturedPokemonsQueryHandler> logger,
        IMapper mapper

        ) : IRequestHandler<GetAllCapturedPokemonsQuery, IEnumerable<PokemonDto>>
    {
        public async Task<IEnumerable<PokemonDto>> Handle(GetAllCapturedPokemonsQuery request, CancellationToken cancellationToken)
        {
            logger.LogInformation("Getting All CapturedPokemons");

            var pokemons = await repository.GetAll();

            var pokemonDtos = mapper.Map<IEnumerable<PokemonDto>>(pokemons);

            return pokemonDtos;
        }
    }
}
