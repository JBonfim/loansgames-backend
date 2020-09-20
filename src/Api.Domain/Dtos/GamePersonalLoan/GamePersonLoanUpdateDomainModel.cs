using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.GamePersonalLoan
{
    public class GamePersonLoanUpdateDomainModel
    {
         [Required(ErrorMessage = "Id é um campo obrigatório")]
         public long Id { get; set; }

        [Required(ErrorMessage = "Pessoa é um campo obrigatório")]
         public long IdPerson { get; set; }

        [Required(ErrorMessage = "Jogo é um campo obrigatório")]
         public long IdGame { get; set; }
        public bool isActive { get; set; } 
    }
}