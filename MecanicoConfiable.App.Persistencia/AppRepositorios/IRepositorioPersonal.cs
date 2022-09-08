using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public interface IRepositorioPersonal
    {
    
        IEnumerable<Personal> GetAll();
    
    }
}