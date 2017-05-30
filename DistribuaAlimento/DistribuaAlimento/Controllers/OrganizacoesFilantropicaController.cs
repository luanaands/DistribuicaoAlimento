using System.Collections.Generic;
using DistribuaAlimento.Models;
using DistribuaAlimento.Servico.Interface;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System;

namespace DistribuaAlimento.Controllers
{
    public class OrganizacoesFilantropicaController : Controller
    {
        public IOrganizacoesFilantropicasServico _IOrganizacoesFilantropicasServico { get; set; }

        // GET: Instituicao
        public ActionResult Index()
        {

            IEnumerable<OrganizacoesFilantropicas> _alvaraIEnumerable = Enumerable.Empty<OrganizacoesFilantropicas>();
            _alvaraIEnumerable = _IOrganizacoesFilantropicasServico.ListarTudo();
            return View(_alvaraIEnumerable);
        }



        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(OrganizacoesFilantropicas organizacoes)
        {
            if (ModelState.IsValid)
            {
                try
                {                   
                    _IOrganizacoesFilantropicasServico.Adicionar(organizacoes);
                }
                catch (Exception ex)
                {

                    ViewBag.msgErro = "Erro no cadastro. " + ex.Message.ToString();
                    return View(organizacoes);
                }
            }
            else
            {

                return View(organizacoes);
            }

            return RedirectToAction("Details", new RouteValueDictionary(organizacoes));
        }
        public ActionResult Details(int id)
        {
            if (ModelState.IsValid)
            {
                OrganizacoesFilantropicas organizacoes = _IOrganizacoesFilantropicasServico.ObterPorID(id);
                return View(organizacoes);
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
                OrganizacoesFilantropicas organizacoes = _IOrganizacoesFilantropicasServico.ObterPorID(id);

                return View(organizacoes);
            }
            else
            {
                return HttpNotFound();
            }
        }



        [HttpPost]
        public ActionResult Edit(OrganizacoesFilantropicas organizacoes)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    //*** altera alvará.

                    _IOrganizacoesFilantropicasServico.Editar(organizacoes);
                }
                catch (Exception ex)
                {
                    ViewBag.msgErro = "Erro na Alteração. " + ex.Message.ToString();
                    return View(organizacoes);
                }
            }
            else
            {

                return View(organizacoes);
            }

            return RedirectToAction("Details", new RouteValueDictionary(organizacoes));
        }



        public ActionResult Delete(int id)
        {

            if (ModelState.IsValid)
            {
                //*** Exclui alvara
                var organizacoes = _IOrganizacoesFilantropicasServico.ObterPorID(id);
                _IOrganizacoesFilantropicasServico.Deletar(organizacoes);

                return RedirectToAction("Index", routeValues: new { id = id });
            }
            else
            {
                return HttpNotFound();
            }
        }
    }


}
