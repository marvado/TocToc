using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TocToc.ModelData.Logic;
using TocToc.Repository.Logic;
using Helpers;

namespace TocToc.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioRepository repoUsuario;

        public UsuarioController()
        {
            repoUsuario = new UsuarioRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (repoUsuario.Obter(usuario.Nome, SHA1.Encode(usuario.Senha)) != null)
                {
                    FormsAuthentication.SetAuthCookie(usuario.Nome, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Dados do Login incorreto");
                }
            }
            return View(usuario);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}
