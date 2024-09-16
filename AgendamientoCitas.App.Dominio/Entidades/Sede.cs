using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AgendamientoCitas.App.Dominio
{
     /// <summary>Class <c>Sede</c>
     /// Modela una Sede del sistema 
     /// </summary>   
    public class Sede
    {
        // Identificador único de cada Sede
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "La direccion es obligatoria")]
        [Display(Name = "Direccion")]        
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El Numero de Telefono es obligatorio")]
        [Display(Name = "Numero de Telefono")]        
        public List<PrestadorDeServicio> PrestadoresDeServicio { get; set; }
    }
}