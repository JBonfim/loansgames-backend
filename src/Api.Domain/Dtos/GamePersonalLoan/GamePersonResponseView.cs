using Api.Domain.Entities;

namespace Api.Domain.Dtos.GamePersonalLoan
{
    public class GamePersonResponseView
    {
         public long Id { get; set; }
        public  PersonEntity Person { get; set; } 
        public  GameEntity Game { get; set; } 

        public bool isActive { get; set; } 
    }
}