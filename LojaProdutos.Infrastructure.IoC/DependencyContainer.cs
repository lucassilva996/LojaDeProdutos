using LojaProdutos.Application.Interfaces;
using LojaProdutos.Application.Services;
using LojaProdutos.Domain.Interfaces;
using LojaProdutos.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaProdutos.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //LojaProduto.Application
            services.AddScoped<ILojaProdutoService, LojaProdutoService>();
            //LojaProduto.Domain.Interfaces e LojaProduto.Infra.Data.Repositories
            services.AddScoped<ILojaProdutoRepository, LojaProdutoRepository>(); 
        }
    }
}
