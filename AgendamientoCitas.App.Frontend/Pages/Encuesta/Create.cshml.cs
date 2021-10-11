using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoCitas.App.Dominio;
using AgendamientoCitas.App.Persistencia.AppRepositorios;

namespace AgendamientoCitas.App.Frontend.Pages
{
    public class CreateModel : PageModel
        {
        private readonly IRepositorioEncuesta _repoEncuesta;
        public Encuesta encuesta {get; set;}
        public CreateModel(IRepositorioEncuesta repoEncuesta)
        {
            _repoEncuesta = repoEncuesta;
        }
        public void OnGet()
        {
            encuesta = new encuesta();
        }
        public IActionResult OnPost(Encuesta encuesta)
        {
            if (ModelState.IsValid)
             {
              _repoEncuesta.AddEncuesta(encuesta);
               return RedirectToPage ("Index");
             }
            else
            {
               return Page();
            }
        }
    }
        
}
