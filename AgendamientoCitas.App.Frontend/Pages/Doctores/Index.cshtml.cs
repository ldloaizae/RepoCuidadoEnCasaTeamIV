using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendamientoCitas.App.Dominio;
using AgendamientoCitas.App.Persistencia;

namespace AgendamientoCitas.App.Frontend.Pages.Doctores
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDoctor _repoDoctor;
        public IEnumerable<Doctor> doctores {get; set;} 
        public IndexModel(IRepositorioDoctor repoDoctor)
        {
            _repoDoctor = repoDoctor;
        }
        public void OnGet()
        {
            doctores = _repoDoctor.GetAllDoctores();
        }
    }
}
