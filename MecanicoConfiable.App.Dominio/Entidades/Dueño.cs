using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MecanicoConfiable.App.Dominio
{
    public class Dueño : Persona
    {
        [Key]
        public int IdDueño { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }


    }
}