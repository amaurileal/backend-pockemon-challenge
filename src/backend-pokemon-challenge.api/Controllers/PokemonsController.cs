using backend_pokemon_challenge.application.Pokemons.Commands.CapturePokemon;
using backend_pokemon_challenge.application.Pokemons.Queries.GetAllCapturedPokemons;
using backend_pokemon_challenge.application.Pokemons.Queries.GetPokemonById;
using backend_pokemon_challenge.application.Pokemons.Queries.GetPokemons;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace backend_pokemon_challenge.api.Controllers
{
    [Route("api/[controller]")]
    public class PokemonsController(IMediator mediator) : ControllerBase
    {
        [HttpPost("capturePokemon")]
        public async Task<IActionResult> CapturePokemon([FromBody] CapturePokemonCommand command)
        {
            var id = await mediator.Send(command);
            return Ok(id);
        }

        [HttpGet]
        public async Task<IActionResult> GetPokemons([FromQuery] GetPokemonsQuery query)
        {
            var pokemons = await mediator.Send(query);
            return Ok(pokemons);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPokemonById(int id)
        {

            var pokemon = await mediator.Send(new GetPokemonByIdQuery()
            {
                Id = id
            }
                        );

            return Ok(pokemon);
        }

        [HttpGet("capturedPokemons")]
        public async Task<IActionResult> CapturedPokemons()
        {
            var capturedPokemons = await mediator.Send(new GetAllCapturedPokemonsQuery());

            return Ok(capturedPokemons);
        }
    }
}
