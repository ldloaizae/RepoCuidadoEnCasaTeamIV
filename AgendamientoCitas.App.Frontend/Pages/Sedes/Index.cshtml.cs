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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioSede _repoSede;
        public IEnumerable<Sede> sedes {get; set;} 
        public IndexModel(IRepositorioSede repoSede)
        {
            _repoSede = repoSede;
        }
        public void OnGet()
        {
            sedes = _repoSede.GetAllSedes();
        }
    }
}
