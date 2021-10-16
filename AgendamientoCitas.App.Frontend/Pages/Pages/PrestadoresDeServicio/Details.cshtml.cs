using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoCitas.App.Dominio;
using AgendamientoCitas.App.Persistencia;

namespace AgendamientoCitas.App.Frontend.Pages.PrestadoresDeServicio
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioPrestadorDeServicio _repoPrestadorDeServicio;
        public PrestadorDeServicio prestadoreDeServicio {get; set;}
        public DetailsModel(IRepositorioPrestadorDeServicio repoPrestadorDeServicio)
        {
            _repoPrestadorDeServicio = repoPrestadorDeServicio;
        }
        public IActionResult OnGet(int id)
        {
            prestadoreDeServicio = _repoPrestadorDeServicio.GetPrestadorDeServicio(id);
            if (prestadoreDeServicio == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
