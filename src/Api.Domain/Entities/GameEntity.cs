using System.Collections.Generic;

namespace Api.Domain.Entities
{
    public class GameEntity: BaseEntity {

       
        public string Descryption { get; set; }
        public string Details { get; set; }
        
         public virtual ICollection<GamePersonalLoanEntity> Gamepersonalloan { get; set; }
    }
}