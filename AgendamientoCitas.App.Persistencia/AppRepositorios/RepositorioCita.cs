using System;
using System.Collections.Generic;
using System.Linq;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia.AppRepositorios
{
    public class RepositorioCita : IRepositorioCita
    {
        private readonly AppContext _appContext = new AppContext();
        Cita IRepositorioCita.AddCita(Cita cita)
        {
           var citaAdicionada = _appContext.Citas.Add(cita);
           _appContext.SaveChanges();
           return citaAdicionada.Entity;
        }
       
        //borrar cita
        void IRepositorioCita.DeleteCita(string IdCita)
        {
            var citaEncontrada = _appContext.Citas.FirstOrDefault(p=>p.Id==IdCita);
            if (citaEncontrada==null)
            return;
            _appContext.Citas.Remove(citaEncontrada);
            _appContext.SaveChanges();
        }
         //buscar Cita
        IEnumerable<Cita> IRepositorioCita.GetAllCitas()
        {
            return _appContext.Citas;
        }
        Cita IRepositorioCita.GetCita(string IdCita)
        {
            return _appContext.Citas.FirstOrDefault(p=>p.Id==IdCita);
        }
        Cita IRepositorioCita.UpdateCita(Cita cita)
        {
            var citaEncontrada = _appContext.Citas.FirstOrDefault(p=>p.Id==cita.Id);
            if (citaEncontrada!= null)
            {
                citaEncontrada.FechaHora =cita.FechaHora ;
                citaEncontrada.Especialidad=cita.Especialidad;
                citaEncontrada.Consultorio=cita.Consultorio;
                citaEncontrada.Duracion=cita.Duracion;
                citaEncontrada.Valor=cita.Valor;
                citaEncontrada.IdMedico=cita.IdMedico;
                citaEncontrada.IdSede=cita.IdSede;
                citaEncontrada.IdEncuesta=cita.IdEncuesta;
                
                _appContext.SaveChanges();
            }
            return citaEncontrada;
        }
    }
}