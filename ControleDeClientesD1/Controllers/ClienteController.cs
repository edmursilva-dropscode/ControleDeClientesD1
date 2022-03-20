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
            return View();
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult DeletarConfirmacao()
        {
            return View();
        }


        //metodos Pust - receber/adicionar informacoes
        [HttpPost]
        public IActionResult Adicionar(Cliente cliente)
        {
            _clienteRepositorio.Adicionar(cliente);
            //retorna para pagina Index
            return RedirectToAction("Index");
        }
    }
}
