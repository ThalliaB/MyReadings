using System.ComponentModel.DataAnnotations;

namespace MyReadings.Models
{
    public class MyReadingsModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Nome do livro")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Digite o Nome do autor")]
        public string Writer { get; set; }

        [Required(ErrorMessage = "Digite o Número de páginas do livro")]
        public int? Pages { get; set; }

        [Required(ErrorMessage = "Digite a Data de ínicio de leitura do livro")]
        public DateTime? Start { get; set; }

        [Required(ErrorMessage = "Digite a Data de finalização de leitura do livro")]
        public DateTime? End { get; set; }

        [Required(ErrorMessage = "Digite uma observação")]
        public string Obs { get; set; }

    }
}
