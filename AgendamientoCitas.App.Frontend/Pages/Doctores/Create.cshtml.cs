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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDoctor _repoDoctor;
        public Doctor doctor {get ; set;}
        public CreateModel(IRepositorioDoctor repoDoctor){
            _repoDoctor = repoDoctor;
        }
        public void OnGet()
        {
            doctor = new Doctor();
        }
        public IActionResult OnPost (Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                _repoDoctor.AddDoctor(doctor);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}


