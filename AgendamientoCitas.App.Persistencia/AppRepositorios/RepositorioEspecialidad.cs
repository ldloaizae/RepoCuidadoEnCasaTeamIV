using System;
using System.Collections.Generic;
using System.Linq;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia.AppRepositorios
{
    public class RepositorioEspecialidad : IRepositorioEspecialidad
    {
        private readonly AppContext _appContext = new AppContext();
        Especialidad IRepositorioEspecialidad.AddEspecialidad(Especialidad especialidad)
        {
           var especialidadAdicionada = _appContext.Especialidades.Add(especialidad);
           _appContext.SaveChanges();
           return especialidadAdicionada.Entity;
        }
       
        //borrar especialidades
        void IRepositorioEspecialidad.DeleteEspecialidad(string CodigoEspecialidad)
        {
            var especialidadEncontrada = _appContext.Especialidades.FirstOrDefault(p=>p.Codigo==CodigoEspecialidad);
            if (especialidadEncontrada==null)
            return;
            _appContext.Especialidades.Remove(especialidadEncontrada);
            _appContext.SaveChanges();
        }
         //buscar especialidad
        IEnumerable<Especialidad> IRepositorioEspecialidad.GetAllEspecialidades()
        {
            return _appContext.Especialidades;
        }
        Especialidad IRepositorioEspecialidad.GetEspecialidad(string CodigoEspecialidad)
        {
            return _appContext.Especialidades.FirstOrDefault(p=>p.Codigo==CodigoEspecialidad);
        }
        Especialidad IRepositorioEspecialidad.UpdateEspecialidad(Especialidad especialidad)
        {
            var especialidadEncontrada = _appContext.Especialidades.FirstOrDefault(p=>p.Codigo==especialidad.Codigo);
            if (especialidadEncontrada!= null)
            {
                especialidadEncontrada.NombreEspecialidad=especialidad.NombreEspecialidad;
                especialidadEncontrada.Valor=especialidad.Valor;

                _appContext.SaveChanges();
            }
            return especialidadEncontrada;
        }
    }
}