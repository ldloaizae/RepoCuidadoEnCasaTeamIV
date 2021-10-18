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
        public int gActual{get; set;}
        public string bActual {get; set;}        
        public IndexModel(IRepositorioCita repoCita)
        {
            _repoCita = repoCita;
        }
        public void OnGet(int? g, string b)
        {
            if (g.HasValue && g.Value != -1)
            {
                gActual = g.Value;
                citas = _repoCita.GetCitasFiltradas(g.Value);                
            }
            else
            {
                gActual = -1;
                if (String.IsNullOrEmpty(b))
                {
                    bActual = "";
                    citas = _repoCita.GetAllCitas();
                }
                else
                {
                    bActual = b;
                    citas = _repoCita.BuscarCita(b);
                }
            }
        }
    }
}
