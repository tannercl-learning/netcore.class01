using System;
using System.Collections.Generic;
using System.Text;

namespace Tanner.OneDrinkAndHome.BusinessLogic.DataTransfers
{
    public class EntityDto : IEntityDto
    {
        public long ID { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
