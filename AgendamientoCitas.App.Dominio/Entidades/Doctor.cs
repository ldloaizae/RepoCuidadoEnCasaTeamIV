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
        public string Especialidad { get; set; }
        [Required(ErrorMessage = "La especialidad del medico es obligatoria")]
        [Display(Name = "Especialidad")] 

        public string Ddoctor { get; set; }
    }
}