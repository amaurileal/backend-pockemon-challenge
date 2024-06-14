using AutoMapper;
using backend_pokemon_challenge.domain.Entities;

namespace backend_pokemon_challenge.application.Services.Dtos
{
    public class PokemonProfile : Profile
    {
        public PokemonProfile() {
            CreateMap<PokemonDto, CapturedPokemon>();
        }
    }
}
