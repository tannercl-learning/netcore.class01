
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tanner.OneDrinkAndHome.Core.Entities
{
    [Table("Bank")]
    public class Bank: EntityBase
    {
        [Required]
        public string Name { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
