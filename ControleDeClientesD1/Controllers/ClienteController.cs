﻿using ControleDeClientesD1.Models;
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
            //editando o cliente
            Cliente cliente = _clienteRepositorio.PesquisarId(id);
            //
            return View(cliente);
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

        [HttpPost]
        public IActionResult Alterar(Cliente cliente)
        {
            _clienteRepositorio.Alterar(cliente);
            //retorna para pagina Index
            return RedirectToAction("Index");
        }
    }
}
