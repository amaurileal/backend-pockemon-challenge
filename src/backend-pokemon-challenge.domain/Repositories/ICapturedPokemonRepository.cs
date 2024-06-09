using backend_pokemon_challenge.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_pokemon_challenge.domain.Repositories
{
    public interface ICapturedPokemonRepository
    {
        Task<int> Capture(CapturedPokemon entity);

        Task<IEnumerable<CapturedPokemon>> GetAll();

        Task<IEnumerable<CapturedPokemon>> GetAllByPokemonMaster(int pokemonMasterId);
    }
}
