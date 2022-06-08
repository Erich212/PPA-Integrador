namespace PPA_Integrador.Entidades
{
    public class CambioEstado
    {
        public DateTime fechaHoraDesde{ get; set; }
        public DateTime fechaHoraHasta { get; set; }
        public Estado estado{ get; set; }
    }
}