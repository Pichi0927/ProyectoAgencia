using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaAgenciaTours.Models
{
    public class Pais
    {
        [Key]
        public int PaisID { get; set; }

        [Required]
        [Display(Name = "Nombre del País")]
        public string Nombre { get; set; }

        public virtual ICollection<Destino> Destinos { get; set; }
    }
}
