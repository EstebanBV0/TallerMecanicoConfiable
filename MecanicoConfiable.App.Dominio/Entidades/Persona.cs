using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MecanicoConfiable.App.Dominio
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    
        public string NumeroTelefono { get; set; }
    
        public string FechaNacimiento { get; set; }
    }
}