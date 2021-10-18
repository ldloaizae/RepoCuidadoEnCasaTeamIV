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
        public int gActual{get; set;}
        public string bActual {get; set;}
        public IndexModel(IRepositorioDoctor repoDoctor)
        {
            _repoDoctor = repoDoctor;
        }
        public void OnGet(int? g, string b)
        {
            if (g.HasValue && g.Value != -1)
            {
                gActual = g.Value;
                doctores = _repoDoctor.GetDoctoresFiltrados(g.Value);                
            }
            else
            {
                gActual = -1;
                if (String.IsNullOrEmpty(b))
                {
                    bActual = "";
                    doctores = _repoDoctor.GetAllDoctores();
                }
                else
                {
                    bActual = b;
                    doctores = _repoDoctor.BuscarDoctores(b);
                }
            }
        }
    }
}