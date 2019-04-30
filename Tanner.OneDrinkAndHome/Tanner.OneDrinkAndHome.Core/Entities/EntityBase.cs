
using System;

namespace Tanner.OneDrinkAndHome.Core.Entities
{
    public abstract class EntityBase : IEntity
    {
        public long ID { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
