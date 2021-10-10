using System.Collections.Generic;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia
{
    public interface IRepositorioEncuesta
    {
        IEnumerable<Encuesta> GetAllEncuestas();
        Encuesta AddEncuesta(Encuesta encuesta);
        Encuesta UpdateEncuesta(Encuesta encuesta);
        void DeleteEncuesta (string IdEncuesta);
        Encuesta GetEncuesta (string IdEncuesta);
    }
}