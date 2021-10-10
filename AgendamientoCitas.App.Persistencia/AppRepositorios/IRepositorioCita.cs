using System.Collections.Generic;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia
{
    public interface IRepositorioCita
    {
        IEnumerable<Cita> GetAllCitas();
        Cita AddCita(Cita cita);
        Cita UpdateCita(Cita cita);
        void DeleteCita (string IdCita);
        Cita GetCita (string IdCita);
    }
}