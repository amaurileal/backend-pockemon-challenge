using FluentValidation;

namespace backend_pokemon_challenge.application.Pokemons.Commands.CapturePokemon
{
    public class CapturePokemonCommandValidator : AbstractValidator<CapturePokemonCommand>
    {
        public CapturePokemonCommandValidator()
        {
            RuleFor(dto => dto.Name).NotEmpty();
            RuleFor(dto => dto.PokemonMasterId).NotEmpty();
            RuleFor(dto => dto.PokemonId).NotEmpty();
        }
    }
}
