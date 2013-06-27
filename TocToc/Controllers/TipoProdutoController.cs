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
        public TipoProdutoController()
        {
            repoTipoProduto = new TipoProdutoRepository();
        }
        public ActionResult Index()
        {
            return View(repoTipoProduto.Obter());
        }

        public ActionResult Incluir()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Incluir(TipoProduto instancia)
        {
            if (ModelState.IsValid)
            {
                if (!repoTipoProduto.Repetido(instancia.Descricao))
                {
                    repoTipoProduto.Incluir(instancia);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Descrição já existente");
                }
            }
            return View(instancia);
        }

    }
}
