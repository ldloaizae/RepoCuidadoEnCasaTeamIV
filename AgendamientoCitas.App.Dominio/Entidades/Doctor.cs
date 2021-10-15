using System.ComponentModel.DataAnnotations;
namespace AgendamientoCitas.App.Dominio
{
     /// <summary>Class <c>Doctor</c>
     /// Modela una Doctor en el sistema 
     /// </summary>   
    public class Doctor:Persona
    {
        // Identificador único de cada Doctor
        public int IdDoctor { get; set; }
        [Required(ErrorMessage = "La especialidad es obligatoria")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Especialidad")]
        public string Especialidad { get; set; }
        //public string IdCita { get; set; }
        
    }
}