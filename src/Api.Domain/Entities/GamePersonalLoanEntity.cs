using System;

namespace Api.Domain.Entities
{
    public class GamePersonalLoanEntity : BaseEntity
    {
        
        public long IdPerson { get; set; }
         public virtual PersonEntity Person { get; set; } 

        public long IdGame { get; set; }
        public virtual GameEntity Game { get; set; } 

        public bool isActive { get; set; } 
        
    }
}