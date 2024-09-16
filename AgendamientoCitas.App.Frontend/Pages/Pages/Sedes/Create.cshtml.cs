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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioSede _repoSede;
        public Sede sede {get; set;}
        public CreateModel(IRepositorioSede repoSede)
        {
            _repoSede = repoSede;
        }
        public void OnGet()
        {
            sede = new Sede();
        }
        public IActionResult OnPost(Sede sede)
        {
            if (ModelState.IsValid)
            {
                _repoSede.AddSede(sede);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }    
}
