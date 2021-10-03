using System;
using System.Collections.Generic;
using System.Linq;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia
{
    public class RepositorioEncuesta : IRepositorioEncuesta
    {
        private readonly AppContext _appContext = new AppContext();
        Encuesta IRepositorioEncuesta.AddEncuesta(Encuesta encuesta)
          {
            var encuestaAdicionada= _appContext.Encuestas.Add(encuesta);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return encuestaAdicionada.Entity; 
          }
        void IRepositorioEncuesta.DeleteEncuesta(string idEncuesta)
          {
            var encuestaEncontrada= _appContext.Encuestas.FirstOrDefault(p =>p.Id==idEncuesta);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if(encuestaEncontrada==null)
              return;
            _appContext.Encuestas.Remove(encuestaEncontrada);
            _appContext.SaveChanges();//Se deben guardar los cambios
          }
        IEnumerable <Encuesta> IRepositorioEncuesta.GetAllEncuestas()
          {
            return _appContext.Encuestas;             
          }
        Encuesta IRepositorioEncuesta.GetEncuesta(String idEncuesta)
          {
           return _appContext.Encuestas.FirstOrDefault(p =>p.Id==idEncuesta);//retorna lo que encuentra
          }
        Encuesta IRepositorioEncuesta.UpdateEncuesta(Encuesta encuesta)
          {
           var encuestaEncontrada= _appContext.Encuestas.FirstOrDefault(p =>p.Id==encuesta.Id);
           //No se busca el idEncuestaEncontrada, se busca la encuestaEncontrada.Id
           if(encuestaEncontrada!=null)
           {
                encuestaEncontrada.Sintomas=encuesta.Sintomas;
                encuestaEncontrada.ModalidadAtencion=encuesta.ModalidadAtencion;
                _appContext.SaveChanges();        
           }
             return encuestaEncontrada; //retorna el prestadorDeServicioEncontrado encontrado
            
          }        
    }
}