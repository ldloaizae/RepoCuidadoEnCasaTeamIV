using System;
using System.Collections.Generic;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia
{
    public interface IRepositorioEncuesta
    {
        IEnumerable<Encuesta> GetAllEncuestas(); //método que me retorna todos las Encuestas
        Encuesta AddEncuesta(Encuesta encuesta);
        Encuesta UpdateEncuesta(Encuesta encuesta);
        void DeleteEncuesta(int idEncuesta);
        Encuesta GetEncuesta(int idEncuesta);         
    }
}