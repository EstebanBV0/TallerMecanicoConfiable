using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MecanicoConfiable.App.Dominio
{
    public class CambioRepuesto
    {
        [Key]
        public int IdCambioRepuesto { get; set; }
        public DateTime FechaHora { get; set; }
        
        //public virtual ICollection<Repuesto> Repuestos { get; set; }

        [ForeignKey ( "Repuesto" )]
        public int IdRepuesto { get; set; }
        public virtual Repuesto Repuesto { get; set; }

        [ForeignKey ( "Vehiculo" )]
        public int IdVehiculo { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }

    }
}