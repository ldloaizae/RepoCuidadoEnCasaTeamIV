using System;
using System.Collections.Generic;
using System.Linq;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia.AppRepositorios
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext = new AppContext();
        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
           var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
           _appContext.SaveChanges();
           return pacienteAdicionado.Entity;
        }
       
        //borrar paciente
        void IRepositorioPaciente.DeletePaciente(string idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p=>p.Id==idPaciente);
            if (pacienteEncontrado==null)
            return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }
         //buscar paciente
        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Pacientes;
        }
        Paciente IRepositorioPaciente.GetPaciente(string idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p=>p.Id==idPaciente);
        }
        Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p=>p.Id==paciente.Id);
            if (pacienteEncontrado!= null)
            {
                pacienteEncontrado.Nombre=paciente.Nombre;
                pacienteEncontrado.Apellidos=paciente.Apellidos;
                pacienteEncontrado.Edad=paciente.Edad;
                pacienteEncontrado.Ciudad=paciente.Ciudad;
                pacienteEncontrado.Telefono=paciente.Telefono;
                pacienteEncontrado.Email=paciente.Email;
                pacienteEncontrado.Genero=paciente.Genero;
                pacienteEncontrado.TipoPaciente=paciente.TipoPaciente;
                pacienteEncontrado.Cita=paciente.Cita;
                _appContext.SaveChanges();
            }
            return pacienteEncontrado;
        }
    }
}