using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoCitas.App.Dominio;
using AgendamientoCitas.App.Persistencia;

namespace AgendamientoCitas.App.Frontend.Pages.Citas
{
    public class IndexModel : PageModel
    {        
        private readonly IRepositorioCita _repoCita;
        public IEnumerable<Cita> citas {get; set;} 
        public IndexModel(IRepositorioCita repoCita)
        {
            _repoCita = repoCita;
        }
        public void OnGet()
        {
            citas = _repoCita.GetAllCitas();
        }
    }
}
