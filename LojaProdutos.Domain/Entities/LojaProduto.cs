using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LojaProdutos.Domain.Entities
{
    public class LojaProduto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduto { get; set; }
        [Required]
        public string NomeProduto { get; set; }
        [Required]
        public decimal PrecoProduto { get; set; }
        [Required]
        public int QuantidadeProduto { get; set; }
        public DateTime DataCadastroProduto { get; set; } = DateTime.Now;
        public DateTime DataAtualizacaoProduto { get; set; } = DateTime.Now;
        public bool ProdutoAtivo { get; set; }
    }
}