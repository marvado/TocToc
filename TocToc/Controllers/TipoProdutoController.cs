using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TocToc.ModelData.Logic;
using TocToc.Repository.Logic;

namespace TocToc.Controllers
{
    public class TipoProdutoController : Controller
    {
        TipoProdutoRepository repoTipoProduto;
        public ActionResult Index()
        {
            repoTipoProduto = new TipoProdutoRepository();
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(TipoProduto instancia)
        {
            if (ModelState.IsValid)
            {
                repoTipoProduto.Incluir(instancia);
                return RedirectToAction("Index");
            }
            return View(instancia);
        }

    }
}
