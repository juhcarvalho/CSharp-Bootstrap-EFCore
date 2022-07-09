using Controle_de_Habito.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controle_de_Habito.Controllers
{
    public class HabitoController : Controller
    {
        // GET: Habito
        public ActionResult Index()
        {
            return View();
        }

        // GET: Habito/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Habito/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Habito/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Habito habito)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Habito/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Habito/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Habito habito)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Habito/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Habito/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Habito habito)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
