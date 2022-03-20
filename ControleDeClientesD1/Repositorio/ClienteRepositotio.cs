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

        public Cliente PesquisarId(int id)
        {
            return _bancoContext.Clientes.FirstOrDefault(x => x.Id == id);
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

        public Cliente Alterar(Cliente cliente)
        {
            Cliente clienteDB = PesquisarId(cliente.Id);
            //veridicar exixtencia de dados
            if (clienteDB == null) throw new System.Exception("Erro ao aatualizar dados do cliente!");
            //atualiza dados de entrada
            clienteDB.Nome = cliente.Nome;
            clienteDB.Dtnascimento = cliente.Dtnascimento;
            clienteDB.Telefone = cliente.Telefone;
            clienteDB.Celular = cliente.Celular;
            clienteDB.Endereco = cliente.Endereco;
            clienteDB.Cidade = cliente.Cidade;
            clienteDB.Estado = cliente.Estado;
            clienteDB.Cep = cliente.Cep;
            clienteDB.Facebook = cliente.Facebook;
            clienteDB.Linkedin = cliente.Linkedin;
            clienteDB.Twitter = cliente.Twitter;
            clienteDB.Instagran = cliente.Instagran;
            //atualiza informacoes cliente no banco de dados
            _bancoContext.Clientes.Update(clienteDB);
            _bancoContext.SaveChanges();
            //
            return clienteDB;
        }
    }
}
