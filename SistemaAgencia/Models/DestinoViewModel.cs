namespace SistemaAgencia.Models
{
    public class DestinoViewModel
    {
        public int DestinoID { get; set; }
        public string Nombre { get; set; }
        public int PaisID { get; set; }
            public virtual PaisViewModel Pais { get; set; }
    }
}
