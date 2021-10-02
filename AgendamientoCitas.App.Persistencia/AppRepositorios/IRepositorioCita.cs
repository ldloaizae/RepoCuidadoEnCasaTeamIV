using System;
using System.Collections.Generic;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia
{
    public interface IRepositorioCita
    {
        IEnumerable<Cita> GetAllCitas(); //método que me retorna todos las Citas
        Cita AddCita(Cita cita);
        Cita UpdateCita(Cita cita);
        void DeleteCita(String idCita);
        Cita GetCita(String idCita); 
    }
}