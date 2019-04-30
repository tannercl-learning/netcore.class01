using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tanner.OneDrinkAndHome.Core.Entities
{
    [Table("Party")]
    public class Party: EntityBase
    {
        public long Pay { get; set; }

        public long Tip { get; set; }

        [Required]
        public string Description { get; set; }        

        public long CreateByID { get; set; }
        public Customer CreateBy { get; set; }

        public ICollection<CustomerParty> Customers { get; set; }

        public long PlaceID { get; set; }
        public Place Place { get; set; }
    }
}
