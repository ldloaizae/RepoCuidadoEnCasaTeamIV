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
    public class EditModel : PageModel
    {
        private readonly IRepositorioPrestadorDeServicio _repoPrestadorDeServicio;
        public PrestadorDeServicio prestadorDeServicio {get; set;}
        public EditModel(IRepositorioPrestadorDeServicio repoPrestadorDeServicio)
        {
            _repoPrestadorDeServicio = repoPrestadorDeServicio;
        }
        public IActionResult OnGet(string id)
        {
            prestadorDeServicio = _repoPrestadorDeServicio.GetPrestadorDeServicio(id);
            if (prestadorDeServicio==null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(PrestadorDeServicio prestadorDeServicio)
        {
            _repoPrestadorDeServicio.UpdatePrestadorDeServicio(prestadorDeServicio);
            return RedirectToPage("Index");
        }
    }
}
