using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAgenciaTours.Models
{
    public class Destino
    {
        [Key]
        public int DestinoID { get; set; }

        [Required]
        [Display(Name = "Nombre del Destino")]
        public string Nombre { get; set; }

        [Required]
        public int PaisID { get; set; }

        [ForeignKey("PaisID")]
        public virtual Pais Pais { get; set; }
    }
}
