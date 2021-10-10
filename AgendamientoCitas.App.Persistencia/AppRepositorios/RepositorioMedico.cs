using System;
using System.Collections.Generic;
using System.Linq;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia.AppRepositorios
{
    public class RepositorioMedico : IRepositorioMedico
    {
        private readonly AppContext _appContext = new AppContext();
        Medico IRepositorioMedico.AddMedico (Medico medico)
        {
           var medicoAdicionado = _appContext.Medicos.Add(medico);
           _appContext.SaveChanges();
           return medicoAdicionado.Entity;
        }
       
        //borrar medico
        void IRepositorioMedico.DeleteMedico (string IdMedico)
        {
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(p=>p.Id==IdMedico);
            if (medicoEncontrado==null)
            return;
            _appContext.Medicos.Remove(medicoEncontrado);
            _appContext.SaveChanges();
        }
         //buscar medico
        IEnumerable<Medico> IRepositorioMedico.GetAllMedicos()
        {
            return _appContext.Medicos;
        }
        Medico IRepositorioMedico.GetMedico (string IdMedico)
        {
            return _appContext.Medicos.FirstOrDefault(p=>p.Id==IdMedico);
        }
        Medico IRepositorioMedico.UpdateMedico(Medico medico)
        {
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(p=>p.Id==medico.Id);
            if (medicoEncontrado!= null)
            {
                medicoEncontrado.Codigo = medico.Codigo;
                medicoEncontrado.Especialidad=medico.Especialidad;
                medicoEncontrado.Cita=medico.Cita;
                medicoEncontrado.Nombre=medicoEncontrado.Nombre;
                medicoEncontrado.Apellidos=medico.Apellidos;
                medicoEncontrado.Edad=medico.Edad;
                medicoEncontrado.Ciudad=medico.Ciudad;
                medicoEncontrado.Telefono=medico.Telefono;
                medicoEncontrado.Email=medico.Email;
                medicoEncontrado.Genero=medico.Genero;
                
                _appContext.SaveChanges();
            }
            return medicoEncontrado;
        }
    }
}