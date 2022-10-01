using System.Collections.Generic;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public interface IRepositorioSeguros
    {
        Seguro AddSeguro(Seguro seguro);
 
        Seguro UpdateSeguro(Seguro SeguroActualizado);

        IEnumerable<ListSegurosFull> GetAll();
/*         IEnumerable<Seguro> GetAllForVehiculo(int IdVehiculo);
 */
        //IEnumerable<Seguro> GetThisSeg(string Seg);
        Seguro GetSegurosId (int IdSeguro);

        //RevisionNiveles GetVehiculoPlaca (string Placa);

        //RevisionNiveles AddMechanic (Vehiculo MechanicUpdate);

        Seguro DeleteSeguro (int IdSeguro);
         
    }
}