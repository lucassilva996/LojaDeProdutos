using LojaProdutos.Application.Interfaces;
using LojaProdutos.Application.ViewModels;
using LojaProdutos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaProdutos.Application.Services
{
    public class LojaProdutoService : ILojaProdutoService
    {
        public ILojaProdutoRepository _lojaProdutoRepository;

        public LojaProdutoService(ILojaProdutoRepository lojaProdutoRepository)
        {
            _lojaProdutoRepository = lojaProdutoRepository;
        }

        public LojaProdutoViewModel GetProdutos()
        {
            return new LojaProdutoViewModel()
            {
                Produtos = _lojaProdutoRepository.GetProdutos()
            };
        }
    }
}
