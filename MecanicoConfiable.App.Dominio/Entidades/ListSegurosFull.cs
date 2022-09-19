namespace MecanicoConfiable.App.Dominio
{
    public class ListSegurosFull
    {

        public int IdSeguro { get; set; }
        public string TipoSeguro { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public int ValorSeguro { get; set; }
        public string Placa { get; set; }
        public int IdVehiculo { get; set; }
        
    }
}