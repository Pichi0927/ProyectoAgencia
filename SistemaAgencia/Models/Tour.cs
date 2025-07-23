using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SistemaAgenciaTours.Models;

namespace SistemaAgencia.Models
{
    public class Tour
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre del Tour")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required]
        [Display(Name = "Precio")]
        [DataType(DataType.Currency)]
        public decimal Precio { get; set; }

        [Required]
        [Display(Name = "Fecha de salida")]
        [DataType(DataType.Date)]
        public DateTime FechaSalida { get; set; }

        [Required]
        [Display(Name = "Fecha de regreso")]
        [DataType(DataType.Date)]
        public DateTime FechaRegreso { get; set; }

        // Relación con Pais (opcional, si el tour está en un país específico)
        public int PaisId { get; set; }
        [ForeignKey("PaisId")]
        public Pais? Pais { get; set; }
    }
}
