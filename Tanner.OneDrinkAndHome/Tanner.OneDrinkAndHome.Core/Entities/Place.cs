using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tanner.OneDrinkAndHome.Core.Entities
{
    [Table("Place")]
    public class Place: EntityBase
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        public ICollection<Party> Parties { get; set; }
    }
}
