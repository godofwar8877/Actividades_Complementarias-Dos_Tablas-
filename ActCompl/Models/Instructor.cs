using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ActCompl.Models
{
    public class Instructor
    {
        [Key]
        
        public int idinstructor { get; set; }

        [StringLength(30, MinimumLength = 1, ErrorMessage = "El colonia debe tener de 1 caracter")]
        public String nombre { get; set; }

        [StringLength(30, MinimumLength = 3, ErrorMessage = "El ciudad debe tener de 3 a 50 caracteres")]
        public String apellidop { get; set; }

        [StringLength(30, MinimumLength = 3, ErrorMessage = "El estado debe tener de 3 a 50 caracteres")]
        public String apellidom { get; set; }

        [StringLength(1, MinimumLength = 1, ErrorMessage = "El estado debe tener de 3 a 50 caracteres")]
        public String sexo { get; set; }

        [StringLength(12, MinimumLength = 3, ErrorMessage = "El estado debe tener de 3 a 50 caracteres")]
        public String rfc { get; set; }

        [StringLength(70, MinimumLength = 3, ErrorMessage = "El estado debe tener de 3 a 50 caracteres")]
        public String formacion { get; set; }

    }
}
