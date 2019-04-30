using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tanner.OneDrinkAndHome.Core.Entities
{
    [Table("Customer")]
    public class Customer: EntityBase
    {
        [Required]
        public string RUT { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public ICollection<CustomerParty> Parties { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
