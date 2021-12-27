using LojaProdutos.Domain.Entities;
using LojaProdutos.Domain.Interfaces;
using LojaProdutos.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaProdutos.Infra.Data.Repositories
{
    public class LojaProdutoRepository : ILojaProdutoRepository
    {
        public AppDbContext _context;

        public LojaProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<LojaProduto> GetProdutos()
        {
            return _context.Produtos;
        }
    }
}
