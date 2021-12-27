using System;
using System.Collections.Generic;
using System.Text;
using LojaProdutos.Domain.Entities;

namespace LojaProdutos.Domain.Interfaces
{
    public interface ILojaProdutoRepository
    {
        IEnumerable<LojaProduto> GetProdutos();
    }
}
