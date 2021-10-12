using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoCitas.App.Dominio;
using AgendamientoCitas.App.Persistencia;

namespace AgendamientoCitas.App.Frontend.Pages.PrestadoresDeservicio
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPrestadorDeServicio _repoPrestadorDeServicio;
        public IEnumerable<PrestadorDeServicio> prestadoresDeServicios {get; set;} 
        public IndexModel(IRepositorioPrestadorDeServicio repoPrestadorDeServicio)
        {
            _repoPrestadorDeServicio = repoPrestadorDeServicio;
        }
        public void OnGet()
        {
            prestadoresDeServicios = _repoPrestadorDeServicio.GetAllPrestadoresDeServicios();
        }
    }
}
