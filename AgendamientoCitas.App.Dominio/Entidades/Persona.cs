using System.ComponentModel.DataAnnotations;
namespace AgendamientoCitas.App.Dominio
{
     /// <summary>Class <c>Persona</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>   
    public class Persona
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Apellido es obligatorio")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "La identificacion es obligatoria")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Identificacion")]
        public string Identificacion { get; set; }
        [Required(ErrorMessage = "La Edad es obligatoria")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Edad")]
        public string Edad { get; set; }
        [Required(ErrorMessage = "La Ciudad es obligatoria")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }
        [Required(ErrorMessage = "El Telefono es obligatorio")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Numero de Telefono")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El Email es obligatorio")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        // Genero de la persona
        public Genero Genero { set; get; }

    }
}