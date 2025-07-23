namespace SistemaAgencia.Models
{
    public class TourViewModel
    {
        public int TourID { get; set; }
        public string Nombre { get; set; }

        public int PaisID { get; set; }
        public virtual PaisViewModel Pais { get; set; }

        public int DestinoID { get; set; }
        public virtual DestinoViewModel Destino { get; set; }

        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }

        public decimal Precio { get; set; }

        public decimal ITBIS => Precio * 0.18m;

        // Duración generada automáticamente según destino
        public int DuracionHoras { get; set; }
        public int DuracionDias { get; set; }

        public DateTime FechaHoraFin => Fecha.Add(Hora).AddDays(DuracionDias).AddHours(DuracionHoras);
        public string Estado => DateTime.Now < Fecha.Add(Hora) ? "Vigente" : "Finalizado";
    }
}
