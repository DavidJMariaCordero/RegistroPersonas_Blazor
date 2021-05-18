﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPersonas_Blazor.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el nombre")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir un número telefonico")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir la cédula")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir una dirección")]
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;
    }
}
