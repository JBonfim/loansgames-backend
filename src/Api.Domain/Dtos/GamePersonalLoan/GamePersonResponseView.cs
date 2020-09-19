using Api.Domain.Entities;

namespace Api.Domain.Dtos.GamePersonalLoan
{
    public class GamePersonResponseView
    {
        public virtual PersonEntity Person { get; set; } 
        public virtual GameEntity Game { get; set; } 

        public bool isActive { get; set; } 
    }
}