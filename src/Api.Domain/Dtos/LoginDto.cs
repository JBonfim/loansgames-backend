using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Login é um campo obrigatório para Login")]
        [StringLength(100, ErrorMessage = "Login deve ter no máximo {1} caracteres.")]
        public string Login { get; set; }

         [Required(ErrorMessage = "Senha é um campo obrigatório para Login")]
        [StringLength(100, ErrorMessage = "Senha deve ter no máximo {1} caracteres.")]
        public string Password { get; set; }
    }
}