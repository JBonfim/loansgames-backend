using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.GamePersonalLoan
{
    public class GamePersonLoanCreateDomainModel
    { 
         [Required(ErrorMessage = "Person é um campo obrigatório")]
         public long IdPerson { get; set; }

          [Required(ErrorMessage = "Id é um campo obrigatório")]
        public long IdGame { get; set; }

        public bool isActive { get; set; } 
    }
}