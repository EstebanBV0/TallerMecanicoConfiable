using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MecanicoConfiable.App.Dominio
{
    public class Credenciales
    {
        [Required]
        public string UserName { get; set; }
         [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}