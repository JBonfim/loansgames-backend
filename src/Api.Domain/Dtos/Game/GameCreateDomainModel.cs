using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Game
{
    public class GameCreateDomainModel
    {
        [Required(ErrorMessage = "Descrição é um campo obrigatório")]
        [StringLength(100, ErrorMessage = "Descrição deve ter no máximo {1} caracteres.")]
         public string Descryption { get; set; }

        
        [StringLength(500, ErrorMessage = "Detalhes deve ter no máximo {1} caracteres.")]
        public string Details { get; set; }
    }
}