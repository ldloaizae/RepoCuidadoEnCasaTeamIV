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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioPrestadorDeServicio _repoPrestadorDeServicio;
        public PrestadorDeServicio prestadorDeServicio {get; set;}
        public CreateModel(IRepositorioPrestadorDeServicio repoPrestadorDeServicio)
        {
            _repoPrestadorDeServicio = repoPrestadorDeServicio;
        }
        public void OnGet()
        {
            prestadorDeServicio = new PrestadorDeServicio();
        }
        public IActionResult OnPost(PrestadorDeServicio prestadorDeServicio)
        {
            _repoPrestadorDeServicio.AddPrestadorDeServicio(prestadorDeServicio);
            return RedirectToPage("Index");
        }
    }
}
