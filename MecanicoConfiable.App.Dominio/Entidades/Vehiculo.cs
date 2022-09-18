using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MecanicoConfiable.App.Dominio
{
    public class Vehiculo

    {
        [Key]
        public int IdVehiculo { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }   
        public string Modelo { get; set; }        
        public int NumeroPasajeros { get; set; }                                                            
        public string PaisOrigen { get; set; }
        public string DescripcionAdicional { get; set; }
        //public virtual Seguro Seguro {get;set;}
        //public virtual ICollection<Dueño> Dueño { get; set; }
        //public virtual ICollection<Conductor> Conductor { get; set; }
        //public virtual ICollection<RevisionNiveles> RevisionNiveles { get; set; }
        //public virtual ICollection<CambioRepuesto> CambioRepuesto { get; set; }

        [ForeignKey ( "Dueño" )]
        public int IdDueño { get; set; }
        public virtual Dueño Dueño { get; set; }
        
        [ForeignKey ( "Mecanico" )]
        public int IdMecanico { get; set; }
        public virtual Mecanico Mecanico { get; set; }

       

    }
}