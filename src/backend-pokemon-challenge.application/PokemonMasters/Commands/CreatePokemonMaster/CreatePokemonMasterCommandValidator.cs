using FluentValidation;

namespace backend_pokemon_challenge.application.PokemonMasters.Commands.CreatePokemonMaster
{
    public class CreatePokemonMasterCommandValidator : AbstractValidator<CreatePokemonMasterCommand>
    {
        public CreatePokemonMasterCommandValidator()
        {
            RuleFor(dto => dto.Name).NotEmpty();
            RuleFor(dto => dto.Age).NotEmpty();
            RuleFor(dto => dto.CPF).NotEmpty();
        }
    }
}
