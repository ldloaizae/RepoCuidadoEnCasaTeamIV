using System;
namespace AgendamientoCitas.App.Dominio
{
     /// <summary>Class <c>Cita</c>
     /// Modela una Cita de paciente en el sistema 
     /// </summary>   
    public class Cita
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        public DateTime FechaHora  { get; set; }
        //public string Hora { get; set; }
        //public string Fecha { get; set; }
        public TipoServicio TipoServicio { get; set; }
        public string Consultorio { get; set; }
        public string Duracion { get; set; }
        public string Valor { get; set; }
        public Paciente Paciente { get; set; }
        public Doctor Doctor { get; set; }
        public Encuesta Encuesta { get; set; }
        public Sede Sede { get; set; }
        
    }
}