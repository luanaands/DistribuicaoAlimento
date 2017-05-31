using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using DistribuaAlimento.Models;
using System.Collections.Generic;
using System.Web.Routing;
using System.Text;

namespace PGE.Alvara.Controllers
{
    public class MenuController : Controller
    {

        public ActionResult Index(string _descricao, int? page)
        {
            Menu menu = new Menu();
            StringBuilder navBar = new StringBuilder();

            ViewBag.navBar = navBar.ToString();

            return View(menu.listaMenu);
        }

        public ActionResult NavBar()
        {
            Menu menu = new Menu();

            menu.listaMenu.Add(new Menu
            {
                id = 1,
                titulo = "Instituicao",
                modulo = "Instituicao",
                acao = "Index"
            });

            menu.listaMenu.Add(new Menu
            {
                id = 1,
                titulo = "Organizacoes",
                modulo = "OrganizacoesFilantropica",
                acao = "Index"
            });

            menu.listaMenu.Add(new Menu
            {
                id = 1,
                titulo = "Evento",
                modulo = "Evento",
                acao = "Create"
            });



            StringBuilder navBar = new StringBuilder();
            navBar.Clear();
            CiriarItemMenuHtml(navBar, menu.listaMenu, 0);
            ViewBag.navBar = navBar.ToString();
            return PartialView("_Navbar");
        }

        private void CiriarItemMenuHtml(StringBuilder menuHtml, IEnumerable<Menu> menu, int nivel)
        {
            var menuLink = "";

            foreach (Menu i in menu)
            {
                menuLink = "../" + i.modulo + "/" + i.acao;
                menuHtml.AppendLine("<li class='dropdown'>");
                menuHtml.AppendLine("<a tabindex='" + i.id + "' href='" + menuLink + "'>" + i.titulo + "</a>");
            }
        }

    }
}
