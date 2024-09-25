using avaliacao.Validations;
using System.ComponentModel.DataAnnotations;

namespace avaliacao.Models
{
    public class NovaCartinha
    {
        [Required(ErrorMessage ="Obrigatório")]
        [MaxLength(255, ErrorMessage = "Máximo de 255 letras ")]
        public string nome {  get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        public string endereço { get; set; }

        [IdadeValidation(ErrorMessage = "Idade máxima de 15 anos")]
        public int idade { get; set; }
        public string texto { get; set; }
        [MaxLength(500, ErrorMessage = "Máximo de 500 caracteres")]


    };
}
