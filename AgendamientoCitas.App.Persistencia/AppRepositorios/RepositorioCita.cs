using System;
using System.Collections.Generic;
using System.Linq;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia
{
    public class RepositorioCita: IRepositorioCita
    {
        private readonly AppContext _appContext = new AppContext();
        Cita IRepositorioCita.AddCita(Cita cita)
          {
            var citaAdicionada= _appContext.Citas.Add(cita);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return citaAdicionada.Entity; 
          }
        void IRepositorioCita.DeleteCita(int idCita)
          {
            var citaEncontrada= _appContext.Citas.FirstOrDefault(p =>p.Id==idCita);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if(citaEncontrada==null)
              return;
            _appContext.Citas.Remove(citaEncontrada);
            _appContext.SaveChanges();//Se deben guardar los cambios
          }
        IEnumerable <Cita> IRepositorioCita.GetAllCitas()
          {
            return _appContext.Citas;
             
          }
        Cita IRepositorioCita.GetCita(int idCita)
          {
           return _appContext.Citas.FirstOrDefault(p =>p.Id==idCita);//retorna lo que encuentra
          }
        Cita IRepositorioCita.UpdateCita(Cita cita)
          {
           var citaEncontrada= _appContext.Citas.FirstOrDefault(p =>p.Id==cita.Id);
           //No se busca el idCitaEncontrada, se busca la citaEncontrada.Id
           if(citaEncontrada!=null)
           {
                citaEncontrada.FechaHora=cita.FechaHora;
                citaEncontrada.TipoServicio=cita.TipoServicio;
                citaEncontrada.Consultorio=cita.Consultorio;
                citaEncontrada.Duracion=cita.Duracion;
                citaEncontrada.Valor=cita.Valor;
                citaEncontrada.Paciente=cita.Paciente;
                citaEncontrada.Doctor=cita.Doctor;
                citaEncontrada.Encuesta=cita.Encuesta;
                citaEncontrada.Sede=cita.Sede;
                _appContext.SaveChanges();        
           }
             return citaEncontrada; //retorna el prestadorDeServicioEncontrado encontrado
            
          }
    }
}