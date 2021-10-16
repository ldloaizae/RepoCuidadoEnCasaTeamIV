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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEncuesta _repoEncuesta;
        public IEnumerable<Encuesta> encuestas {get; set;} 
        public IndexModel(IRepositorioEncuesta repoEncuesta)
        {
            _repoEncuesta = repoEncuesta;
        }
        public void OnGet()
        {
            encuestas = _repoEncuesta.GetAllEncuestas();
        }
    }
}
