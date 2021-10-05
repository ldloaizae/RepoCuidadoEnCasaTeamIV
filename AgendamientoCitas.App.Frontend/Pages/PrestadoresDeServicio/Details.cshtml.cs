using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using AgendamientoCitas.App.Dominio;
using AgendamientoCitas.App.Persistencia;

namespace AgendamientoCitas.App.Frontend.Pages.PrestadorDeServicio
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioPrestadorDeServicio _repoPrestadorDeServicio;
        public PrestadorDeServicio prestadorDeServicio {get; set;}
        public DetailsModel(IRepositorioPrestadorDeServicio repoPrestadorDeServicio)
        {
            _repoPrestadorDeServicio = repoPrestadorDeServicio;
        }
        public void OnGet(int id)
        {
            prestadorDeServicio = _repoPrestadorDeServicio.GetPrestadorDeServicio(id);
            if (prestadorDeServicio == null)
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
