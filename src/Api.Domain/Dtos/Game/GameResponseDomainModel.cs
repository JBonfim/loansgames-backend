using System;

namespace Api.Domain.Dtos.Game
{
    public class GameResponseDomainModel
    {
       public long Id { get; set; }
        public string Descryption { get; set; }
        public string Details { get; set; }
        public DateTime CreateAt { get; set; }
    }
}