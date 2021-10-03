using System;
using System.Collections.Generic;
using System.Linq;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia
{
     public class RepositorioPrestadorDeServicio : IRepositorioPrestadorDeServicio
     {
          private readonly AppContext _appContext = new AppContext();
          PrestadorDeServicio IRepositorioPrestadorDeServicio.AddPrestadorDeServicio(PrestadorDeServicio prestadorDeServicio)
          {
            var prestadorDeServicioAdicionado= _appContext.PrestadoresDeServicios.Add(prestadorDeServicio);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return prestadorDeServicioAdicionado.Entity; 
          }

          void IRepositorioPrestadorDeServicio.DeletePrestadorDeServicio(string idPrestadorDeServicio)
          {
            var prestadorDeServicioEncontrado= _appContext.PrestadoresDeServicios.FirstOrDefault(p =>p.Id==idPrestadorDeServicio);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if(prestadorDeServicioEncontrado==null)
              return;
            _appContext.PrestadoresDeServicios.Remove(prestadorDeServicioEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios
          }

          IEnumerable <PrestadorDeServicio> IRepositorioPrestadorDeServicio.GetAllPrestadoresDeServicios()
          {
            return _appContext.PrestadoresDeServicios;
             
          }

        PrestadorDeServicio IRepositorioPrestadorDeServicio.GetPrestadorDeServicio  (String idPrestadorDeServicio)
          {
           return _appContext.PrestadoresDeServicios.FirstOrDefault(p =>p.Id==idPrestadorDeServicio);//retorna lo que encuentra
          }

        PrestadorDeServicio IRepositorioPrestadorDeServicio.UpdatePrestadorDeServicio  (PrestadorDeServicio prestadorDeServicio)
          {
           var prestadorDeServicioEncontrado= _appContext.PrestadoresDeServicios.FirstOrDefault(p =>p.Id==prestadorDeServicio.Id);
           //No se busca el idprestadorDeServicioEncontrado, se busca el prestadorDeServicioEncontrado.Id
           if(prestadorDeServicioEncontrado!=null)
           {
                prestadorDeServicioEncontrado.RazonSocial=prestadorDeServicio.RazonSocial;
                prestadorDeServicioEncontrado.Nit=prestadorDeServicio.Nit;
                prestadorDeServicioEncontrado.TipoDePrestador=prestadorDeServicio.TipoDePrestador;
                prestadorDeServicioEncontrado.Telefono=prestadorDeServicio.Telefono;
                _appContext.SaveChanges();        
           }
             return prestadorDeServicioEncontrado; //retorna el prestadorDeServicioEncontrado encontrado
            
          }  
     }
}
// implementa la interfaz