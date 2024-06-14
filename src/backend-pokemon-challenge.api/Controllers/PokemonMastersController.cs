using backend_pokemon_challenge.application.PokemonMasters.Commands.CreatePokemonMaster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace backend_pokemon_challenge.api.Controllers;

[Route("api/[controller]")]
public class PokemonMastersController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreatePokemonMasterCommand command)
    {
        int id = await mediator.Send(command);
        return Ok(id);
    }
}
