using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MecanicoConfiable.App.Dominio
{
    public class CambioRepuesto
    {
        [Key]
        public int IdCambioRepuesto { get; set; }
        public string FechaHora { get; set; }
        
        public virtual ICollection<Repuesto> Repuestos { get; set; }

        [ForeignKey ( "Vehiculo" )]
        public int IdVehiculo { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}