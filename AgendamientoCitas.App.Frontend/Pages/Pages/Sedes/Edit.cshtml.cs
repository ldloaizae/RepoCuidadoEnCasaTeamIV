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
    public class EditModel : PageModel
    {
        private readonly IRepositorioSede _repoSede;
        public Sede sede {get; set;}
        public EditModel(IRepositorioSede repoSede)
        {
            _repoSede = repoSede;
        }
        public IActionResult OnGet(int id)
        {
            sede = _repoSede.GetSede(id);
            if (sede==null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Sede sede)
        {
            _repoSede.UpdateSede(sede);
            return RedirectToPage("Index");
        }
    }
}
