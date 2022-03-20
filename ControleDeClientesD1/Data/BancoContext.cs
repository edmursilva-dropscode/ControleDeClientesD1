using ControleDeClientesD1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientesD1.Data
{
    public class BancoContext : DbContext
    {
        //conexao com banco de dados SqlServer
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        //configuracao do contexto da tabela Clientes
        public DbSet<Cliente> Clientes { get; set; }

    }
}
