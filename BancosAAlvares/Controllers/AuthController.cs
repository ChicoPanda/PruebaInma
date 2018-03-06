using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BancosAAlvares.Controllers
{
    public class AuthController : Controller
    {
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
        public ActionResult Login(BancoUsers Usuario)
        {
            if (ModelState.IsValid)
            {
                BancoUsers authUser = null;
                BancosEntities contexto = new BancosEntities();
                {
                    authUser = contexto.BancoUsers.FirstOrDefault(u => u.Login == Usuario.Login && u.Password == Usuario.Password);
                }
                if (authUser != null)
                {
                    FormsAuthentication.SetAuthCookie(authUser.Login, false);
                    Session["USUARIO"] = authUser;
                    return RedirectToAction("Lista", "Cuentas");
                }
                else
                {

                    ModelState.AddModelError("CredentialError", "Usuario o contraseña incorrecta");
                    //return null;
                    return View();
                }
            }
            else
            {
                return View();

            }
        }
        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["USUARIO"] = null;
            return RedirectToAction("Logout", "Index");
        }
    }
}
