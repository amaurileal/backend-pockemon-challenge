using backend_pokemon_challenge.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_pokemon_challenge.domain.Repositories
{
    public interface IPokemonMasterRepository
    {
        Task<int> Create(PokemonMaster entity);

        

        Task Delete(PokemonMaster entity);

        Task<IEnumerable<PokemonMaster>> GetAllByAsync();

        Task<PokemonMaster> FindByIdAsync(int id);

        Task SaveChanges();

    }
}
