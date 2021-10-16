using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgendamientoCitas.App.Dominio
{
     /// <summary>Class <c>Sede</c>
     /// Modela una Sede del sistema 
     /// </summary>   
    public class Sede
    {
        // Identificador único de cada Sede
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Nombre de Sede")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La Direccion es obligatoria")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Direccion de Sede")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El Telefono es obligatorio")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [Display(Name = "Telefono de Sede")]
        public string Telefono { get; set; }
        public List<PrestadorDeServicio> PrestadoresDeServicio { get; set; }
    }
}