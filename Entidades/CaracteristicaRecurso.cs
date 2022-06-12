namespace PPA_Integrador.Entidades
{
    public class CaracteristicaRecurso
    {
        public int Valor { get; set; }
        public Caracteristica Caracteristica { get; set; }
        
        public CaracteristicaRecurso(int valor, Caracteristica caracteristica) 
        {
            this.Valor = valor;
            this.Caracteristica = caracteristica;

        }
        public string mostrarCaracteristicaRecurso()
        {
            return this.Caracteristica.ToString() + " " + this.Valor;

        }
    }
}