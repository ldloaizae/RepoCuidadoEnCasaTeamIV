using System.ComponentModel.DataAnnotations;
namespace AgendamientoCitas.App.Dominio
{
     /// <summary>Class <c>Prestador de Servicios</c>
     /// Modela una Prestador de servicios del sistema 
     /// </summary>   
    public class PrestadorDeServicio
    {
        // Identificador único de cada paciente
        public string Id { get; set; }
        [Required(ErrorMessage = "La Razon Social es obligatoria")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Razon Social")]
        public string RazonSocial { get; set; }
        [Required(ErrorMessage = "El NIT es obligatorio")]
        public string Nit { get; set; }
        [Required(ErrorMessage = "El Tipo de Prestador es obligatorio")]
        [Display(Name = "Tipo de Prestador")]
        public TipoDePrestador TipoDePrestador { get; set; }
        [Required(ErrorMessage = "El Numero de Telefono es obligatorio")]
        [Display(Name = "Numero de Telefono")]
        public string Telefono { get; set; }
        
    }
}