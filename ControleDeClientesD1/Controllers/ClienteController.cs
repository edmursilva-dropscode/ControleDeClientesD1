using ControleDeClientesD1.Models;
using ControleDeClientesD1.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientesD1.Controllers
{
    public class ClienteController : Controller
    {

        //insercao das informacoes pelo repositorio cliente
        private readonly IClienteRepositotio _clienteRepositorio;

        public ClienteController(IClienteRepositotio clienteRepositotio)
        {
            _clienteRepositorio = clienteRepositotio;
        }

        //metodos Get - carregar/entrar informacoes
        public IActionResult Index()
        {
            //listando os clientes
            List<Cliente> clientes = _clienteRepositorio.ListarClientes();
            //
            return View(clientes);
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            //pesquisando o cliente
            Cliente cliente = _clienteRepositorio.PesquisarId(id);
            //
            return View(cliente);
        }

        public IActionResult DeletarConfirmacao(int id)
        {
            //pesquisando o cliente
            Cliente cliente = _clienteRepositorio.PesquisarId(id);
            return View(cliente);
        }

        public IActionResult Deletar(int id)
        {

            try
            {
                //valida eero ao deletar cliemte
                bool deletado = _clienteRepositorio.Deletar(id);
                if(deletado)
                { 
                    TempData["MensagemSucesso"] = "Cliente deletado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = $"Erro ao deletar o cliente!";
                }
                //retorna para pagina Index
                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao deletar o cliente! erro:{erro.Message}";
                //retorna para pagina Index
                return RedirectToAction("Index");
            }

        }

        //metodos Pust - receber/adicionar informacoes
        [HttpPost]
        public IActionResult Adicionar(Cliente cliente)
        {
            try
            {
                //valida de a model tem erro
                if (ModelState.IsValid)
                {
                    _clienteRepositorio.Adicionar(cliente);
                    TempData["MensagemSucesso"] = "Cliente adicionado com sucesso!";
                    //retorna para pagina Index
                    return RedirectToAction("Index");
                }
                return View(cliente);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao adicionar o cliente! erro:{erro.Message}";
                //retorna para pagina Index
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Alterar(Cliente cliente)
        {
            try
            {
                //valida de a model tem erro
                if (ModelState.IsValid)
                {
                    _clienteRepositorio.Alterar(cliente);
                    TempData["MensagemSucesso"] = "Cliente alterado com sucesso!";
                    //retorna para pagina Index
                    return RedirectToAction("Index");
                }
                return View(cliente);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao alterar o cliente! erro:{erro.Message}";
                //retorna para pagina Index
                return RedirectToAction("Index");
            }

        }

    }
}
