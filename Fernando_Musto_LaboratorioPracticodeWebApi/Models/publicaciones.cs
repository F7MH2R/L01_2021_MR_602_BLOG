﻿using System.ComponentModel.DataAnnotations;

namespace Fernando_Musto_LaboratorioPracticodeWebApi.Models
{
    public class publicaciones
    {
        [Key]
        public int publicacionId { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public int usuarioId { get; set; }
    }
}
