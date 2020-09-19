using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.GamePersonalLoan
{
    public class GamePersonLoanUpdateDomainModel
    {
         [Required(ErrorMessage = "Id é um campo obrigatório")]
         public long Id { get; set; }
        public bool isActive { get; set; } 
    }
}