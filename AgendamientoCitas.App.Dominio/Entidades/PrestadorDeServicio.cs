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
        [Display(Name = "Razon Social")]
        public string RazonSocial { get; set; }
        public string Nit { get; set; }
        [Display(Name = "Tipo de Prestador")]
        public TipoDePrestador TipoDePrestador { get; set; }
        [Display(Name = "Numero de Telefono")]
        public string Telefono { get; set; }
        
    }
}