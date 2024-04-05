using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PracticaMVC.Models;

namespace PracticaMVC.Controllers
{
    public class EquiposController : Controller

    {
        private readonly equiposDbContext _equiposDbContext;

        public EquiposController(equiposDbContext equiposDbContext)
        {
            _equiposDbContext = equiposDbContext;
        }

        public IActionResult Index()
        {
            var ListaDeMarcas = (from m in _equiposDbContext.marcas select m).ToList();
            ViewData["ListadoDeMarcas"] = new SelectList(ListaDeMarcas, "id_marcas", "nombre_marca");

            var listadpDeEquipos = (from e in _equiposDbContext.equipos
                                    join m in _equiposDbContext.marcas on e.marca_id equals m.id_marcas
                                    select new
                                    {
                                        nombre = e.nombre,
                                        descricion = e.descripcion,
                                        marca_id = e.marca_id,
                                        marca_nombre = m.nombre_marca
                                    }).ToList();

            ViewData["listadoEquipo"] = listadpDeEquipos;

            return View();
        }

        public IActionResult CrearEquipos( equipos nuevoEquipo)
        {
            _equiposDbContext.Add(nuevoEquipo);
            _equiposDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
