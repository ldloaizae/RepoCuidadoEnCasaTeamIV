using System;
using System.Collections.Generic;
using System.Linq;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia.AppRepositorios
{
    public class RepositorioEncuesta : IRepositorioEncuesta
    {
        private readonly AppContext _appContext = new AppContext();
        Encuesta IRepositorioEncuesta.AddEncuesta(Encuesta encuesta)
        {
           var encuestaAdicionada = _appContext.Encuestas.Add(encuesta);
           _appContext.SaveChanges();
           return encuestaAdicionada.Entity;
        }
       
        //borrar encuesta
        void IRepositorioEncuesta.DeleteEncuesta(string IdEncuesta)
        {
            var encuestaEncontrada = _appContext.Encuestas.FirstOrDefault(p=>p.Id==IdEncuesta);
            if (encuestaEncontrada==null)
            return;
            _appContext.Encuestas.Remove(encuestaEncontrada);
            _appContext.SaveChanges();

        }
         //buscar encuesta
        IEnumerable<Encuesta> IRepositorioEncuesta.GetAllEncuestas()
        {
            return _appContext.Encuestas;
        }
        Encuesta IRepositorioEncuesta.GetEncuesta(string IdEncuesta)
        {
            return _appContext.Encuestas.FirstOrDefault(p=>p.Id==IdEncuesta);
        }
        Encuesta IRepositorioEncuesta.UpdateEncuesta(Encuesta encuesta)
        {
            var encuestaEncontrada = _appContext.Encuestas.FirstOrDefault(p=>p.Id==encuesta.Id);
            if (encuestaEncontrada!= null)
            {
                encuestaEncontrada.Pregunta1=encuesta.Pregunta1;
                encuestaEncontrada.Pregunta2=encuesta.Pregunta2;
                encuestaEncontrada.Pregunta3=encuesta.Pregunta3;
                encuestaEncontrada.Pregunta4=encuesta.Pregunta4;
                encuestaEncontrada.ModalidadAtencion=encuesta.ModalidadAtencion;

                _appContext.SaveChanges();
            }
            return encuestaEncontrada;
        }
    }
}