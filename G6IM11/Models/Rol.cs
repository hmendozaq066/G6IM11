using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G6IM11.Models
{
    public class Rol
    {
        [Key]
        public int Rol_id { get; set; }
        //ErrorMessage nos permite modificar el mensaje de error en la validación del modelo
        [Required(ErrorMessage = "El nombre del rol es obligatorio")]
        [MinLength(10, ErrorMessage = "El nombre del rol debe tener mínimo 10 letras")]
        [MaxLength(60, ErrorMessage = "El nombre del rol debe tener máximo 60 letras")]
        public string Descripcion { get; set; }
    }
}
