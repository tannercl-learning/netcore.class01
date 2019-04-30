using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tanner.OneDrinkAndHome.Core.Entities
{
    [Table("Account")]
    public class Account: EntityBase
    {
        public AccountType Type { get; set; }

        public long BankID { get; set; }
        public Bank Bank { get; set; }

        public long CustomerID { get; set; }
        public Customer Customer { get; set; }

        public ICollection<CustomerParty> Parties { get; set; }

    }
}
