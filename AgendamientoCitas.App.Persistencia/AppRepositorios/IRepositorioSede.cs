using System;
using System.Collections.Generic;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia
{
    public interface IRepositorioSede
    {
        IEnumerable<Sede> GetAllSedes(); //método que me retorna todos las Sedes
        Sede AddSede(Sede sede);
        Sede UpdateSede(Sede sede);
        void DeleteSede(int idSede);
        Sede GetSede(int IdSede);
        //public PrestadorDeServicio AsignarPrestadorDeServicio(int idSede, PrestadorDeServicio prestadorDeServicio);
        IEnumerable<Sede> GetSedesFiltradas(int sede);
    
        IEnumerable<Sede> BuscarSede(String Nombre); 
    }
}