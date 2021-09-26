namespace HospiEnCasa.App.Dominio
{
     /// <summary>Class <c>Sede</c>
     /// Modela una Sede del sistema 
     /// </summary>   
    public class Sede
    {
        // Identificador único de cada Sede
        public string IdSede { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        
    }
}