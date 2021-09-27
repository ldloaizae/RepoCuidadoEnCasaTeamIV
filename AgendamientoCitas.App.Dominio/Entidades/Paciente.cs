namespace AgendamientoCitas.App.Dominio
{
     /// <summary>Class <c>Paciente</c>
     /// Modela una Paciente en general en el sistema 
     /// </summary>   
    public class Paciente:Persona
    {
        // Identificador único de cada paciente
        public string Id { get; set; }
        public TipoPaciente TipoPaciente { get; set; }
        public string IdCita { get; set; }
        
    }
}