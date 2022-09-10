using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MecanicoConfiable.App.Dominio
{
    public class Conductor : Persona
    {
        [Key]
        public int IdConductor { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        [ForeignKey ( "Vehiculo" )]
        public int IdVehiculo { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}