using System;
using DistribuaAlimento.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DistribuaAlimento.Servico.Interface;
using System.Web.Routing;

namespace DistribuaAlimento.Controllers
{
    public class AlimentoController : Controller
    {

        public IAlimentoServico _IAlimentoServico { get; set; }
        public IEstoqueServico _IEstoqueServico { get; set; }
        public IInstituicaoServico _IInstituicaoServico { get; set; }
        public IEventoServico _IEventoServico { get; set; }

        public ActionResult Index()
        {

            IEnumerable<Alimento> _alimentoIEnumerable = Enumerable.Empty<Alimento>();
            _alimentoIEnumerable = _IAlimentoServico.ListarTudo();
            return View(_alimentoIEnumerable);
        }

        [HttpGet]
        public ActionResult Create()
        {
            carregarCombo();
            return View();
        }

        private void carregarCombo()
        {


            ViewBag.estoque = _IEstoqueServico.ListarTudo();
        }

        [HttpPost]
        public ActionResult Create(Alimento alimento)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    carregarCombo();
                    _IAlimentoServico.Adicionar(alimento);
                }
                catch (Exception ex)
                {
                    carregarCombo();
                    ViewBag.msgErro = "Erro no cadastro. " + ex.Message.ToString();
                    return View(alimento);
                }
            }
            else
            {

                return View(alimento);
            }

            return RedirectToAction("Details", new RouteValueDictionary(alimento));
        }


        public ActionResult Details(int id)
        {
            if (ModelState.IsValid)
            {
                Alimento alimento = _IAlimentoServico.ObterPorID(id);
                return View(alimento);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (ModelState.IsValid)
            {
                Alimento alimento = _IAlimentoServico.ObterPorID(id);

                return View(alimento);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpPost]
        public ActionResult Edit(Alimento alimento)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    //*** altera alvará.

                    _IAlimentoServico.Editar(alimento);
                }
                catch (Exception ex)
                {
                    ViewBag.msgErro = "Erro na Alteração. " + ex.Message.ToString();
                    return View(alimento);
                }
            }
            else
            {

                return View(alimento);
            }

            return RedirectToAction("Details", new RouteValueDictionary(alimento));
        }


        public ActionResult Delete(int id)
        {

            if (ModelState.IsValid)
            {
              
                var alimento = _IAlimentoServico.ObterPorID(id);
                _IAlimentoServico.Deletar(alimento);

                return RedirectToAction("Index", routeValues: new { id = id });
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}

