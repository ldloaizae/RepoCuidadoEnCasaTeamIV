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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioDoctor _repoDoctor;
        public Doctor doctor {get; set;}
        public DetailsModel(IRepositorioDoctor repoDoctor)
        {
            _repoDoctor = repoDoctor;
        }
        public IActionResult OnGet(int id)
        {
            doctor = _repoDoctor.GetDoctor(id);
            if (doctor == null)
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
