using System;
using System.Collections.Generic;
using System.Linq;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia
{
    public class RepositorioDoctor:IRepositorioDoctor
    {
        private readonly AppContext _appContext = new AppContext();
        Doctor IRepositorioDoctor.AddDoctor(Doctor doctor)
          {
            var doctorAdicionado = _appContext.Doctores.Add(doctor);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return doctorAdicionado.Entity; 
          }
        void IRepositorioDoctor.DeleteDoctor(int idDoctor)
          {
            var doctorEncontrado= _appContext.Doctores.FirstOrDefault(p =>p.Id==idDoctor);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if(doctorEncontrado==null)
              return;
            _appContext.Doctores.Remove(doctorEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios
          }
        IEnumerable <Doctor> IRepositorioDoctor.GetAllDoctores()
          {
            return _appContext.Doctores;
             
          }
        Doctor IRepositorioDoctor.GetDoctor(int idDoctor)
          {
           return _appContext.Doctores.FirstOrDefault(p =>p.Id==idDoctor);//retorna lo que encuentra
          }
        Doctor IRepositorioDoctor.UpdateDoctor(Doctor doctor)
          {
           var doctorEncontrado= _appContext.Doctores.FirstOrDefault(p =>p.Id==doctor.Id);
           //No se busca el idDoctorEncontrado, se busca la doctorEncontrado.Id
           if(doctorEncontrado!=null)
           {
                doctorEncontrado.Especialidad=doctor.Especialidad;
                doctorEncontrado.IdCita=doctor.IdCita;
                doctorEncontrado.Nombre=doctor.Nombre;
                doctorEncontrado.Apellidos=doctor.Apellidos;
                doctorEncontrado.Identificacion=doctor.Identificacion;
                doctorEncontrado.Edad=doctor.Edad;
                doctorEncontrado.Ciudad=doctor.Ciudad;
                doctorEncontrado.Telefono=doctor.Telefono;
                doctorEncontrado.Email=doctor.Email;
                doctorEncontrado.Genero=doctor.Genero;
                _appContext.SaveChanges();        
           }
             return doctorEncontrado; //retorna el prestadorDeServicioEncontrado encontrado
            
          }
    }
}