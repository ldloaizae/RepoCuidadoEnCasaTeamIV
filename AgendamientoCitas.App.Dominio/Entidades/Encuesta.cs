namespace HospiEnCasa.App.Dominio
{
     /// <summary>Class <c>Encuesta</c>
     /// Modela una Encuesta que realiza el sistema en el sistema 
     /// </summary>   
    public class Encuesta
    {
        // Identificador único de cada paciente
        public string IdEncuesta { get; set; }
        public string Sintomas { get; set; }
        public string ModalidadAtencion { get; set; }
        
    }
}