using System;
namespace HospiEnCasa.App.Dominio
{
     /// <summary>Class <c>Cita</c>
     /// Modela una Cita de paciente en el sistema 
     /// </summary>   
    public class Cita
    {
        // Identificador único de cada persona
        public string IdCita { get; set; }
        public DateTime FechaHora  { get; set; }
        //public string Hora { get; set; }
        //public string Fecha { get; set; }
        public TipoServicio TipoServicio { get; set; }
        public string Consultorio { get; set; }
        public string Duracion { get; set; }
        public string Valor { get; set; }
        public string IdPaciente { get; set; }
        public string IdDoctor { get; set; }
        public string IdEncuesta { get; set; }
        public string IdSede { get; set; }
        
    }
}