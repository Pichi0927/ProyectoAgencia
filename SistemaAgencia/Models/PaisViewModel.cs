namespace SistemaAgencia.Models
{
    public class PaisViewModel
    {
        public int PaisID { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<DestinoViewModel> Destinos { get; set; }
    }
}
