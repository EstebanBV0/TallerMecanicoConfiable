

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MecanicoConfiable.App.Dominio
{
    public class Repuesto
    {
        [Key]
        public int IdRepuesto { get; set; }
        public string Repuest { get; set;}
        public string Valor { get; set; }

       [ForeignKey ( "CambioRepuesto" )]
        public int IdCambioRepuesto { get; set; }
        public virtual CambioRepuesto CambioRepuesto { get; set; }
    }
}