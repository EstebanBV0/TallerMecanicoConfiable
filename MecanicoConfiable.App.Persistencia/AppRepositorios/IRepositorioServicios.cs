using MecanicoConfiable.App.Dominio;


namespace MecanicoConfiable.App.Persistencia
{
    public interface IRepositorioServicios

    {
         IEnumerable<Servicio> GetAllForAux();
         IEnumerable<Servicio> GetAllForMech();

    }
}