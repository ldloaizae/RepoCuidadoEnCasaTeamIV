using System.Collections.Generic;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia
{
    public interface IRepositorioEspecialidad
    {
        IEnumerable<Especialidad> GetAllEspecialidades();
        Especialidad AddEspecialidad(Especialidad especialidad);
        Especialidad UpdateEspecialidad(Especialidad especialidad);
        void DeleteEspecialidad (string codigoEspecialidad);
        Especialidad GetEspecialidad (string codigoEspecialidad);
    }
}