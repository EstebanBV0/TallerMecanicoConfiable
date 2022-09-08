using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MecanicoConfiable.App.Dominio
{
    public class RevisionNiveles
    {
        [Key]
        public int IdNiveles { get; set; }
        public string FechaHora { get; set; }
        public string NivelAceite { get; set; }
        public string NivelLiquidoFrenos { get; set; }
        public string NivelRefrigerante { get; set; }
        public string NivelLiquidDireccion { get; set; }
        

        [ForeignKey ( "Mecanico" )]
        public int IdMecanico { get; set; }
        public virtual Mecanico Mecanico { get; set; }
        
        [ForeignKey ( "Vehiculo" )]
        public int IdVehiculo { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }


        
    }
}