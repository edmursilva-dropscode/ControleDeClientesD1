using ControleDeClientesD1.Data;
using ControleDeClientesD1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientesD1.Repositorio
{
    public class ClienteRepositotio : IClienteRepositotio
    {
        private readonly BancoContext _bancoContext;

        //injetando os dados no repositor do nosso BancoContext
        public ClienteRepositotio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<Cliente> ListarClientes()
        {
            return _bancoContext.Clientes.ToList();
        }

        public Cliente Adicionar(Cliente cliente)
        {
            //adicionar dados no banco de dados
            _bancoContext.Clientes.Add(cliente);
            //commit dados no banco de dados
            _bancoContext.SaveChanges();
            //
            return cliente;
        }


    }
}
