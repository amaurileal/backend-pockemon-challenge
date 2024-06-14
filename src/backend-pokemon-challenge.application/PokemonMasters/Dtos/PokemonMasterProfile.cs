using AutoMapper;
using backend_pokemon_challenge.application.PokemonMasters.Commands.CreatePokemonMaster;
using backend_pokemon_challenge.domain.Entities;

namespace backend_pokemon_challenge.application.PokemonMasters.Dtos
{
    public class PokemonMasterProfile : Profile
    {
        public PokemonMasterProfile()
        {
            CreateMap<CreatePokemonMasterCommand, PokemonMaster>();
        }
    }
}
