using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers
{
    public class ProductoController1 : Controller
    {
        // GET: ProductoController1
        public ActionResult Index()
        {
            return View(Producto);
        }

        // GET: ProductoController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductoController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductoController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ProductoController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductoController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: ProductoController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductoController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
