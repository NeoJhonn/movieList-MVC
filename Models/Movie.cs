using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MoviesMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [DisplayName("Título do Filme:")]
        [Required(ErrorMessage = "Digite o título do Filme")]
        public string? Title { get; set; }

        [DisplayName("Gênero do Filme:")]
        [Required(ErrorMessage = "Digite o gênero do Filme")]
        public string? Genre { get; set; }

        [DisplayName("Data de Lançamento:")]
        [Required(ErrorMessage = "Insira a data de lançamento")]
        [DataType(DataType.Date)]
        public DateTime RealeseDate { get; set; }

    }
}
