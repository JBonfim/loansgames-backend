using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Person
{
    public class PersonCreateDomainModel
    {
         [Required(ErrorMessage = "Nome é um campo obrigatório")]
        [StringLength(100, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
         public string Name { get; set; }

        [Required(ErrorMessage = "Endereço é um campo obrigatório")]
        [StringLength(500, ErrorMessage = "Endereço deve ter no máximo {1} caracteres.")]
        public string Address { get; set; }

        
        [StringLength(100, ErrorMessage = "Telefone deve ter no máximo {1} caracteres.")]        

         public string phone { get; set; }
    }
}