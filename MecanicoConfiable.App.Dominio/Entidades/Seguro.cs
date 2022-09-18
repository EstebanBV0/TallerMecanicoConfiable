using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MecanicoConfiable.App.Dominio
{
    public class Seguro
    {
        [Key]
        public int IdSeguro { get; set; }
        public string TipoSeguro { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public int ValorSeguro { get; set; }

        [ForeignKey ( "Vehiculo" )]
        public int IdVehiculo { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }

    }
}