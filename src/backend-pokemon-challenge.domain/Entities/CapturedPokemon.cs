using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend_pokemon_challenge.domain.Entities
{
    public class CapturedPokemon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public PokemonMaster PokemonMaster { get; set; }

        [Required]
        public int PokemonMasterId { get; set; }

        [Required]
        public int PokemonId { get; set; }

        [Required]
        public string Name { get; set; } = default!;

        public string Url { get; set; } = default!;

    }
}
