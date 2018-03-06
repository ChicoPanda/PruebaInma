using BancosAAlvares.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BancosAAlvares.Controllers
{
    public class CuentasController : Controller
    {
 
            BancoDatos pruebita = new BancoDatos();
            // GET: Cuentas
            public ActionResult Index()
            {
                return View();
            }

            public ActionResult Lista()
            {

                return View(pruebita.Cuentas.ToList());
            }
        
    }
}