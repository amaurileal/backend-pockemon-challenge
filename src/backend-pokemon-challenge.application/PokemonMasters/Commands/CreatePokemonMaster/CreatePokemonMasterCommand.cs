using MediatR;

namespace backend_pokemon_challenge.application.PokemonMasters.Commands.CreatePokemonMaster
{
    public class CreatePokemonMasterCommand : IRequest<int>
    {
        public string Name { get; set; } = default!;

        public int Age { get; set; }

        public string CPF { get; set; } = default!;
    }
}
