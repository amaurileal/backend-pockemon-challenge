using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace backend_pokemon_challenge.domain.Entities
{
    public class PokemonMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }=default!;

        [Required]
        public int Age { get; set; }

        [MaxLength(11)]
        [Required]
        public string CPF { get; set; } = default!;

    }
}
