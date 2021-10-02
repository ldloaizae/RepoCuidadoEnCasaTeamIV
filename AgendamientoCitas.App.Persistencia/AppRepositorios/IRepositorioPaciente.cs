using System;
using System.Collections.Generic;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes(); //método que me retorna todos los Paciente
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(String idPaciente);
        Paciente GetPaciente(String idPaciente);
    }
}