using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MecanicoConfiable.App.Dominio
{
    public class Auxiliar : Persona
    {
        [Key]
        public int IdAuxiliar { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        
    }
}