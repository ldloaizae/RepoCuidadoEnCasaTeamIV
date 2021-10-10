using System;
using System.Collections.Generic;
using System.Linq;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia.AppRepositorios
{
    public class RepositorioSede : IRepositorioSede
    {
        private readonly AppContext _appContext = new AppContext();
        Sede IRepositorioSede.AddSede(Sede sede)
        {
           var sedeAdicionada = _appContext.Sedes.Add(sede);
           _appContext.SaveChanges();
           return sedeAdicionada.Entity;
        }
       
        //borrar sede
        void IRepositorioSede.DeleteSede(string IdSede)
        {
            var sedeEncontrada = _appContext.Sedes.FirstOrDefault(p=>p.Id==IdSede);
            if (sedeEncontrada==null)
            return;
            _appContext.Sedes.Remove(sedeEncontrada);
            _appContext.SaveChanges();
        }
         //buscar sede
        IEnumerable<Sede> IRepositorioSede.GetAllSedes()
        {
            return _appContext.Sedes;
        }
        Sede IRepositorioSede.GetSede(string IdSede)
        {
            return _appContext.Sedes.FirstOrDefault(p=>p.Id==IdSede);
        }
        Sede IRepositorioSede.UpdateSede(Sede sede)
        {
            var sedeEncontrada = _appContext.Sedes.FirstOrDefault(p=>p.Id==sede.Id);
            if (sedeEncontrada!= null)
            {
                sedeEncontrada.NombreSede=sede.NombreSede;
                sedeEncontrada.Ciudad=sede.Ciudad;
                sedeEncontrada.Direccion=sede.Direccion;
                sedeEncontrada.Telefono=sede.Telefono;

                _appContext.SaveChanges();
            }
            return sedeEncontrada;
        }
    }
}