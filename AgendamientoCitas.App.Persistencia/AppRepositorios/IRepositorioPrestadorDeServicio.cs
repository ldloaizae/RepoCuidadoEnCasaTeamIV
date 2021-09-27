using System;
using System.Collections.Generic;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia
{
    public interface IRepositorioPrestadorDeServicio
    {
        IEnumerable<PrestadorDeServicio> GetAllPrestadoresDeServicios(); //método que me retorna todos los prestadorDeServicio
        PrestadorDeServicio AddPrestadorDeServicio(PrestadorDeServicio prestadorDeServicio);
        PrestadorDeServicio UpdatePrestadorDeServicio(PrestadorDeServicio prestadorDeServicio);
        void DeletePrestadorDeServicio(String idPrestadorDeServicio);
        PrestadorDeServicio GetPrestadorDeServicio(String idPrestadorDeServicio);
    }
}