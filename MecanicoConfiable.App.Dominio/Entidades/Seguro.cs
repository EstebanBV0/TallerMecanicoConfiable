using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MecanicoConfiable.App.Dominio
{
    public class Seguro
    {
        [Key, ForeignKey ("Vehiculo")]
        public int IdSeguro { get; set; }
        public string TipoSeguro { get; set; }
        public string FechaCompra { get; set; }
        public string FechaInicial { get; set; }
        public string FechaFinal { get; set; }
        public string ValorSeguro { get; set; }

        public virtual Vehiculo Vehiculo { get; set; }

    }
}