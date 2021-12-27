using LojaProdutos.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaProdutos.Application.Interfaces
{
    public interface ILojaProdutoService
    {
        LojaProdutoViewModel GetProdutos();
    }
}
