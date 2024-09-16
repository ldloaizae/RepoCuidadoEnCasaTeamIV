using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoCitas.App.Dominio;
using AgendamientoCitas.App.Persistencia;

namespace AgendamientoCitas.App.Frontend.Pages.Encuestas
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioEncuesta _repoEncuesta;
        public Encuesta encuesta {get; set;}
        public DetailsModel(IRepositorioEncuesta repoEncuesta)
        {
            _repoEncuesta = repoEncuesta;
        }
        public IActionResult OnGet(int id)
        {
            encuesta = _repoEncuesta.GetEncuesta(id);
            if (encuesta == null)
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
