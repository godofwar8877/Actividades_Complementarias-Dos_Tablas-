using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ActCompl.Models
{
    public class Alumnos
    {
        [Key]
        public long numero_control { get; set; }


        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El nombre debe tener de 3 a 50 caracteres")]
        public String Nombre { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El apellidop debe tener de 3 a 50 caracteres")]
        public String apellidop { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El apellidom debe tener de 3 a 50 caracteres")]
        public String apellidom { get; set; }

        [Required]
        [StringLength(45, MinimumLength = 3, ErrorMessage = "El apellidom debe tener de 3 a 50 caracteres")]
        public String email { get; set; }

        [Required]
        public long telefono { get; set; }

        public DateTime fecha_nacimiento { get; set; }

        [StringLength(1, MinimumLength = 1, ErrorMessage = "El colonia debe tener de 1 caracter")]
        public String sexo { get; set; }

        [StringLength(45, MinimumLength = 3, ErrorMessage = "El ciudad debe tener de 3 a 50 caracteres")]
        public String calle { get; set; }

        [StringLength(10, MinimumLength = 3, ErrorMessage = "El estado debe tener de 3 a 50 caracteres")]
        public String numero_ext { get; set; }

        [StringLength(10, MinimumLength = 3, ErrorMessage = "El estado debe tener de 3 a 50 caracteres")]
        public String numero_int { get; set; }

        [StringLength(45, MinimumLength = 3, ErrorMessage = "El estado debe tener de 3 a 50 caracteres")]
        public String colonia { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "El estado debe tener de 3 a 50 caracteres")]
        public String password { get; set; }

        [StringLength(1, MinimumLength = 1, ErrorMessage = "El estado debe tener de 3 a 50 caracteres")]
        public String estatus { get; set; }

        public int semestre { get; set; }

        public int localidades_idlocalidades { get; set; }

        public int rol_idrol { get; set; }

    }
}



