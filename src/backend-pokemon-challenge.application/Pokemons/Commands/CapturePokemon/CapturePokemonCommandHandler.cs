using AutoMapper;
using backend_pokemon_challenge.domain.Entities;
using backend_pokemon_challenge.domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace backend_pokemon_challenge.application.Pokemons.Commands.CapturePokemon
{
    public class CapturePokemonCommandHandler(
        ICapturedPokemonRepository repository,
        ILogger<CapturePokemonCommandHandler> logger,
        IMapper mapper
        ) : IRequestHandler<CapturePokemonCommand, int>
    {
        public async Task<int> Handle(CapturePokemonCommand request, CancellationToken cancellationToken)
        {
            logger.LogInformation($"Creating a new Captured Pokemon: {request}");

            //do mapping
            var capturedPokemon = mapper.Map<CapturedPokemon>(request);

            //insert
            return await repository.Capture(capturedPokemon);
        }
    }
}
