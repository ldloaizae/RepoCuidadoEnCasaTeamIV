using System;
using System.Collections.Generic;
using AgendamientoCitas.App.Dominio;

namespace AgendamientoCitas.App.Persistencia
{
    public interface IRepositorioDoctor
    {
        IEnumerable<Doctor> GetAllDoctores(); //método que me retorna todos los Doctores
        Doctor AddDoctor(Doctor doctor);
        Doctor UpdateDoctor(Doctor doctor);
        void DeleteDoctor(int idDoctor);
        Doctor GetDoctor(int idDoctor); 

        IEnumerable<Doctor> GetDoctoresFiltrados(int doctor);
    
        IEnumerable<Doctor> BuscarDoctores(String Nombre);    
    }
}