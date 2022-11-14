using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NovosAresApi.NET.Models
{

    [Table("Cliente")]
    public class Cliente
    
    {
            [Key]
            public int ClienteId { get; set; }


            [Required(ErrorMessage = "Informe o nome do cliente")]
            public string Nome { get; set; }


            [Required(ErrorMessage = "Informe o telefone do cliente")]
            public string Telefone { get; set; }


            [Required(ErrorMessage = "Informe o CPF do cliente")]
            public string CPF { get; set; }


            [Required(ErrorMessage = "Informe o estado")]
            public string Estado { get; set; }

            [Required(ErrorMessage = "Informe o municipio")]
            public string Municipio { get; set; }

            [Required(ErrorMessage = "Informe a rua")]
            public string Rua { get; set; }

            [Required(ErrorMessage = "Informe o bairro")]
            public string Bairro{ get; set; }

            [Required(ErrorMessage = "Informe o numero")]
            public int Numero { get; set; }

            [Required(ErrorMessage = "Informe o cep")]
            public string Cep { get; set; }

            public DateTime Data_cli { get; set; }

    }
}
