using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia
{
    public class RepositorioSede : IRepositorioSede
    {
        private readonly AppContext _appContext = new AppContext();
        Sede IRepositorioSede.AddSede(Sede sede)
          {
            var sedeAdicionada= _appContext.Sedes.Add(sede);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return sedeAdicionada.Entity; 
          }
        void IRepositorioSede.DeleteSede(int idSede)
          {
            var sedeEncontrada= _appContext.Sedes.FirstOrDefault(p =>p.Id==idSede);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if(sedeEncontrada==null)
              return;
            _appContext.Sedes.Remove(sedeEncontrada);
            _appContext.SaveChanges();//Se deben guardar los cambios
          }
        IEnumerable <Sede> IRepositorioSede.GetAllSedes()
          {
            return _appContext.Sedes;
             
          }
        Sede IRepositorioSede.GetSede(int idSede)
          {
            var sede = _appContext.Sedes
                      .Where(p =>p.Id==idSede)
                      .Include(p =>p.PrestadoresDeServicio)
                      .FirstOrDefault();
            return sede;          
           //return _appContext.Sedes.FirstOrDefault(p =>p.Id==idSede);//retorna lo que encuentra
          }
        Sede IRepositorioSede.UpdateSede(Sede sede)
          {
           var sedeEncontrada= _appContext.Sedes.FirstOrDefault(p =>p.Id==sede.Id);
           //No se busca el idSedeEncontrada, se busca la sedeEncontrada.Id
           if(sedeEncontrada!=null)
           {
                sedeEncontrada.Nombre=sede.Nombre;
                sedeEncontrada.Direccion=sede.Direccion;
                sedeEncontrada.Telefono=sede.Telefono;
                _appContext.SaveChanges();        
           }
             return sedeEncontrada; //retorna el prestadorDeServicioEncontrado encontrado
            
          }
        List<PrestadorDeServicio> IRepositorioSede.AddPrestadorDeServicio(int idSede, int idPrestadordeServicio)
        {
            var sedeEncontrada = _appContext.Sedes.Find(idSede);
            if (sedeEncontrada != null)
            {
                var prestadorEncontrado = _appContext.PrestadoresDeServicios.Find(idPrestadordeServicio);
                if (prestadorEncontrado != null)
                {
                    sedeEncontrada.PrestadoresDeServicio.Add(prestadorEncontrado);
                    _appContext.SaveChanges();
                }
                return sedeEncontrada.PrestadoresDeServicio;
            }
            return null;
        }
    }
}