using System.Collections.Generic;

namespace Api.Domain.Entities
{
    public class PersonEntity : BaseEntity
    {

      
         public string Name { get; set; }
        public string Address { get; set; }

         public string phone { get; set; }

          public virtual ICollection<GamePersonalLoanEntity> Gamepersonalloan { get; set; }
    }
}