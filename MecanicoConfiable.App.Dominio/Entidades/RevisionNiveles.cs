using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MecanicoConfiable.App.Dominio
{
    public class RevisionNiveles
    {
        [Key]
        public int IdNiveles { get; set; }
        public DateTime FechaHora { get; set; }
        public DateTime NivelAceite { get; set; }
        public int NivelLiquidoFrenos { get; set; }
        public int NivelRefrigerante { get; set; }
        public int NivelLiquidDireccion { get; set; }
    
        [ForeignKey ( "Vehiculo" )]
        public int IdVehiculo { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
        
    }
}