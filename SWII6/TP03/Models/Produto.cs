using System.ComponentModel.DataAnnotations;

namespace TP03.Models
{
    public class Produto
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O preço é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal Preco { get; set; }

        public string Descricao { get; set; }

        [Required(ErrorMessage = "A quantidade é obrigatória.")]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade não pode ser negativa.")]
        public int Quantidade { get; set; }
    }
}
// Lucas Veira Dos Santos Martins CB3020223 & Miguel da Silva Pataro CB3021564