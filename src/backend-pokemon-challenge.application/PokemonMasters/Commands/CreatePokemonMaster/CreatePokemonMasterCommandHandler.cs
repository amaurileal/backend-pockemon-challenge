using AutoMapper;
using backend_pokemon_challenge.domain.Entities;
using backend_pokemon_challenge.domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace backend_pokemon_challenge.application.PokemonMasters.Commands.CreatePokemonMaster
{
    public class CreatePokemonMasterCommandHandler(
        IPokemonMasterRepository repository,
        ILogger<CreatePokemonMasterCommandHandler> logger,
        IMapper mapper
        ) : IRequestHandler<CreatePokemonMasterCommand, int>
    {
        public async Task<int> Handle(CreatePokemonMasterCommand request, CancellationToken cancellationToken)
        {
            logger.LogInformation($"Creating a new Pokemon Master: {request}");

            //do mapping
            var pokemonMaster = mapper.Map<PokemonMaster>(request);

            //insert
            return await repository.Create(pokemonMaster);
        }
    }
}
