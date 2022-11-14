using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NovosAresApi.NET.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Informe o email do Usuario")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha do Usuario")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe a permissao do Usuario")]
        public string Permissao { get; set; }

      

      

    }
}
