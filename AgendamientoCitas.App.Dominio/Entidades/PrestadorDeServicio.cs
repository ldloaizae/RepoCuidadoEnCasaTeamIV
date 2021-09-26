namespace HospiEnCasa.App.Dominio
{
     /// <summary>Class <c>Prestador de Servicios</c>
     /// Modela una Prestador de servicios del sistema 
     /// </summary>   
    public class PrestadorDeServicios
    {
        // Identificador único de cada paciente
        public string IdPrestadorDeServicios { get; set; }
        public string RazonSocial { get; set; }
        public string Nit { get; set; }
        public TipoDePrestador TipoDePrestador { get; set; }
        public string Telefono { get; set; }
        
    }
}