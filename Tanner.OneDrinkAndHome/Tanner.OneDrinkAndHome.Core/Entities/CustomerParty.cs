
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tanner.OneDrinkAndHome.Core.Entities
{
    [Table("CustomerParty")]
    public class CustomerParty : IEntity
    {
        public DateTime CreateDate { get; set; }

        public long Pay { get; set; }

        public long Tip { get; set; }

        public bool IsPaid { get; set; }

        public bool IsClosed { get; set; }

        public long CustomerID { get; set; }
        public Customer Customer { get; set; }

        public long PartyID { get; set; }
        public Party Party { get; set; }

        public long? AccountPayID { get; set; }
        public Account AccountPay { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
