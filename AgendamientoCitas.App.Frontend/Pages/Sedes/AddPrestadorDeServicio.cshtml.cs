using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoCitas.App.Dominio;
using AgendamientoCitas.App.Persistencia;

namespace AgendamientoCitas.App.Frontend.Pages.Sedes
{
    public class AddPrestadorDeServicioModel : PageModel
    {
        private readonly IRepositorioSede _repoSede;
        private readonly IRepositorioPrestadorDeServicio _repoPrestadorDeServicio;
        public Sede sede {get; set;}
        public IEnumerable<PrestadorDeServicio> prestadoresDeServicio { get; set; }
        public AddPrestadorDeServicioModel(IRepositorioSede repoSede, IRepositorioPrestadorDeServicio repoPrestadorDeServicio)
        {
            _repoSede = repoSede;
            _repoPrestadorDeServicio = repoPrestadorDeServicio;
        }
        public void OnGet(int id)
        {
            sede = _repoSede.GetSede(id);
            prestadoresDeServicio = _repoPrestadorDeServicio.GetAllPrestadoresDeServicios();
        }
        public IActionResult OnPost(int idSede, int idPrestadorDeServicio)
        {
            _repoSede.AddPrestadorDeServicio(idSede,idPrestadorDeServicio);
            return RedirectToPage("Details", new{id=idSede});
        }
    }
}
