using backend_pokemon_challenge.application.Services.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_pokemon_challenge.application.Pokemons.Queries.GetPokemons
{
    public class GetPokemonsQuery : IRequest<IEnumerable<PokemonDto>>
    {
        public int Limit { get; set; }

        public int Offset { get; set; }
    }
}
