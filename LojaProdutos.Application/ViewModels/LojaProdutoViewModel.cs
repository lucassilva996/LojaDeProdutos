using LojaProdutos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaProdutos.Application.ViewModels
{
    public class LojaProdutoViewModel
    {
        public IEnumerable<LojaProduto> Produtos { get; set; }
    }
}
