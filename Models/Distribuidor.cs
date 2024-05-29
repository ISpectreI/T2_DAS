using System.ComponentModel.DataAnnotations;

namespace T2_Alexander_Solis.Models
{
    public class Distribuidor
    {

        [Key]

        public int Id { get; set; }

        public string Nombredistribuidor { get; set; }
        [Required(ErrorMessage = "Es obligatorio")]
        public string Razonsocial { get; set; }
        [Required(ErrorMessage = "Es obligatorio")]
        public string telefono { get; set; }
        [Required(ErrorMessage = "Es obligatorio")]

        [Range(1900, 3000, ErrorMessage = "Error. Año inválido. Ingrese nuevamente")]
        public string AnioInicioOperacion { get; set; }
        [Required(ErrorMessage = "Es obligatorio")]
        public string Contacto { get; set; }
       
    }
}
