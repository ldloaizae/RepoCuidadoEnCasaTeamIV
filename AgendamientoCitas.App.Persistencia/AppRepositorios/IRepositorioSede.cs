using System.Collections.Generic;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia
{
    public interface IRepositorioSede
    {
        IEnumerable<Sede> GetAllSedes();
        Sede AddSede(Sede sede);
        Sede UpdateSede(Sede sede);
        void DeleteSede (string ISede);
        Sede GetSede (string IdSede);
    }
}