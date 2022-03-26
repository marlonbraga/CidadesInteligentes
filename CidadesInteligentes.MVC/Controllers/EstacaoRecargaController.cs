using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CidadesInteligentes.Aplicacao.Interfaces;
using AutoMapper;
using CidadesInteligentes.Dominio.Entidades;
using CidadesInteligentes.MVC.Models;
using Microsoft.AspNetCore.Http;
using CidadesInteligentes.Infra.Dados.Config;
using CidadesInteligentes.Aplicacao.Aplicacoes;

namespace CidadesInteligentes.MVC.Controllers
{
    public class EstacaoRecargaController : Controller
    {
        private readonly IEstacoesRecargaApp _estacaoRecargaApp;

        public EstacaoRecargaController(IEstacoesRecargaApp estacaoRecargaApp)
        {
            _estacaoRecargaApp = estacaoRecargaApp;
        }

        // GET: EstacaoRecarga
        public ActionResult Index()
        {
            return View(_estacaoRecargaApp.Listar());
        }

        // GET: EstacaoRecarga/Details/5
        public ActionResult Details(Guid id)
        {
            var estacaoRecarga = _estacaoRecargaApp.RecuperarPorId(id);
            return View(estacaoRecarga);
        }

        // GET: EstacaoRecarga/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstacaoRecarga/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                estacaoRecarga.Id = Guid.NewGuid();
                _estacaoRecargaApp.Adicionar(estacaoRecarga);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }

        // GET: EstacaoRecarga/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        // POST: EstacaoRecarga/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                _estacaoRecargaApp.Atualizar(estacaoRecarga);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstacaoRecarga/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        // POST: EstacaoRecarga/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                // TODO: Add delete logic here
                _estacaoRecargaApp.Excluir(estacaoRecarga);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
