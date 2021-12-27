using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaProdutos.Infra.Data.Context
{
    class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {

        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder
                .UseSqlServer("Data Source=LUCAS-PC; Initial Catalog=LojaProdutos;Integrated Security=False; User ID=sa; Password=ld201013") ;

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
