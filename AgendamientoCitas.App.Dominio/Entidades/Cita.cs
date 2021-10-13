using System;
using System.ComponentModel.DataAnnotations;
namespace AgendamientoCitas.App.Dominio
{
     /// <summary>Class <c>Cita</c>
     /// Modela una Cita de paciente en el sistema 
     /// </summary>   
    public class Cita
    {
        // Identificador único de cada persona
        public int Id { get; set; }

        [Required(ErrorMessage = "Elija la fecha de la cita")]
        [Display(Name = "FechaHora")]

        public DateTime FechaHora  { get; set; }

        //public string Hora { get; set; }
        //public string Fecha { get; set; }
        [Required(ErrorMessage = "Elija el tipo de servicio deseado")]
        [Display(Name = "TipoServicio")]

        public TipoServicio TipoServicio { get; set; }

        [Required(ErrorMessage = "Consultorio del Doctor")]
        [Display(Name = "Consultorio")]

        public string Consultorio { get; set; }

        [Required(ErrorMessage = "Establesca la duración de la cita")]
        [MaxLength(25, ErrorMessage = "Maximo 25 caracteres")]
        [Display(Name = "Duracion")]

        public string Duracion { get; set; }

        [Required(ErrorMessage = "Establesca el valor de la cita")]
        [MaxLength(25, ErrorMessage = "Maximo 25 caracteres")]
        [Display(Name = "Valor")]

        public string Valor { get; set; }

        [Required(ErrorMessage = "Nombre del paciente")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Paciente")]

        public Paciente Paciente { get; set; }

        [Required(ErrorMessage = "Nombre del doctor que atiende la consulta")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Doctor")]

        public Doctor Doctor { get; set; }

        [Required(ErrorMessage = "Tipo de atención requerido segun la encuesta")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Encuesta")]

        public Encuesta Encuesta { get; set; }

        [Required(ErrorMessage = "Nombre de la sede de atención para la cita")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Sede")]

        public Sede Sede { get; set; }
        
    }
}