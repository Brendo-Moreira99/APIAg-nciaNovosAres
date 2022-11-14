using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovosAresApi.NET.Models
{
    [Table("Pacote")]
    public class Pacote
    {
        [Key]
        public int PacoteId { get; set; }

        [Required(ErrorMessage = "Informe a partida do voo")]
        public string Partida { get; set; }

        [Required(ErrorMessage = "Informe a quantidade de pessoas")]
        public string Qtd_pessoas { get; set; }

        [Required(ErrorMessage = "Informe o destino do voo")]
        public string Destino { get; set; }

        [Required(ErrorMessage = "Informe a data de partida do voo")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Pacote_ida { get; set; }

        [Required(ErrorMessage = "Informe a data de volta do voo")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Pacote_volta { get; set; }

        [Required(ErrorMessage = "Informe o valor do pacote")]

        public Double Valor { get; set; }

        [Required(ErrorMessage = "Informe o transfer da viagem")]

        public String Transfer { get; set; }

        [Required(ErrorMessage = "Informe a rua do hotel")]
        public string RuaHotel { get; set; }

        [Required(ErrorMessage = "Informe o número do hotel")]
        public int NumeroHotel { get; set; }

        [Required(ErrorMessage = "Informe o CEP do hotel")]
        public string CepHotel { get; set; }

        [Required(ErrorMessage = "Informe o Estado do hotel")]
        public string EstadoHotel { get; set; }

        [Required(ErrorMessage = "Informe o Município do hotel")]
        public string MunicipioHotel { get; set; }

        [Required(ErrorMessage = "Informe o Nome do hotel")]
        public string NomeHotel { get; set; }

        [Required(ErrorMessage = "Informe a quantidade de quartos do hotel")]
        public int Qtd_quartosHotel { get; set; }

    }
}
