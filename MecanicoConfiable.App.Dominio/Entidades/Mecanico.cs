using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MecanicoConfiable.App.Dominio
{
    public class Mecanico : Persona
    {
        [Key]
        public int IdMecanico { get; set; }
        public string Direccion { get; set; }
        public string NivelEstudio { get; set; } 

        //public virtual ICollection<Vehiculo> Vehiculo { get; set; }

          
        

    }
}