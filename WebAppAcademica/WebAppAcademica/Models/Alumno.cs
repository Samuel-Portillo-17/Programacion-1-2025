using System.ComponentModel.DataAnnotations;

namespace WebAppAcademica.Models
{
    public class Alumno {
        [Key]
        public int AlumnoId { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
    }
}
