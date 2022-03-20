using ControleDeClientesD1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientesD1.Repositorio
{
    public interface IClienteRepositotio
    {
        //metodos do repositorio cliente
        Cliente PesquisarId(int id);

        List<Cliente> ListarClientes();

        Cliente Adicionar(Cliente cliente);

        Cliente Alterar(Cliente cliente);

        bool Deletar(int id);
    }
}
