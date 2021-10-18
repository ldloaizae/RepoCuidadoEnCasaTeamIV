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
        public int gActual{get; set;}
        public string bActual {get; set;}        
        public IndexModel(IRepositorioSede repoSede)
        {
            _repoSede = repoSede;
        }
        public void OnGet(int? g, string b)
        {
            if (g.HasValue && g.Value != -1)
            {
                gActual = g.Value;
                sedes = _repoSede.GetSedesFiltradas(g.Value);                
            }
            else
            {
                gActual = -1;
                if (String.IsNullOrEmpty(b))
                {
                    bActual = "";
                    sedes = _repoSede.GetAllSedes();
                }
                else
                {
                    bActual = b;
                    sedes = _repoSede.BuscarSede(b);
                }
            }
        }
    }
}