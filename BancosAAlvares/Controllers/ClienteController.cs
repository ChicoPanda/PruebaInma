using BancosAAlvares.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BancosAAlvares.Controllers
{
    
        public class ClientesController : Controller
        {
            private BancoDatos dbContext = new BancoDatos();

            // GET: Clientes
            public ActionResult Index()
            {
                return View();
            }

            public ActionResult Lista()
            {
                return View(dbContext.Clientes);
            }

           
            [HttpPost]
            public ActionResult CreateModel(Clientes cliente)
            {
                String view = "CreateModel";
                if (ModelState.IsValid)
                {
                    dbContext.Clientes.Add(cliente);
                    dbContext.SaveChanges();
                    view = "Lista";
                }
                return RedirectToAction(view);
            }

            [HttpGet]
            public ActionResult Edit(int id)
            {
                Clientes cliente = dbContext.Clientes.Find(id);

                if (cliente == null)
                {
                    return HttpNotFound();
                }
                return View(cliente);
            }

            [HttpPost]
            public ActionResult Edit(Clientes cliente)
            {
                String view = "Edit";
                if (ModelState.IsValid)
                {
                    dbContext.Entry(cliente).State = EntityState.Modified;
                    dbContext.SaveChanges();
                    view = "Lista";
                }
                return RedirectToAction(view);
            }

            [HttpGet]
            public ActionResult Details(int id)
            {
                Clientes cliente = dbContext.Clientes.Find(id);
                if (cliente == null)
                {
                    return HttpNotFound();
                }
                return View(cliente);
            }

            [HttpGet]
            public ActionResult Delete(int id)
            {
                Clientes cliente = dbContext.Clientes.Find(id);
                if (cliente == null)
                {
                    return HttpNotFound();
                }
                return View(cliente);
            }

            [HttpPost, ActionName("Delete")]
            public ActionResult DeleteConfirmed(int id)
            {
                Clientes cliente = dbContext.Clientes.Find(id);
                dbContext.Clientes.Remove(cliente);
                dbContext.SaveChanges();

                String view = "Lista";
                return RedirectToAction(view);
            }
        }
    
}