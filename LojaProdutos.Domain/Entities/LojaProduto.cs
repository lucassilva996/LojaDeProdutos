using System;
using System.Collections.Generic;
using System.Text;

namespace LojaProdutos.Domain.Entities
{
    public class LojaProduto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal PrecoProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public bool ProdutoAtivo { get; set; }
    }
}