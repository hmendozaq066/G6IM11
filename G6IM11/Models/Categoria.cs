using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G6IM11.Models
{
    //1.-Agregar using
    public class Categoria
    {
        [Key]
        [Display(Name = "Categoría")]
        public int Categoria_id { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(60)]
        [Display(Name = "Descripción de la categoría")]
        public string Descripcion { get; set; }
    }
}
