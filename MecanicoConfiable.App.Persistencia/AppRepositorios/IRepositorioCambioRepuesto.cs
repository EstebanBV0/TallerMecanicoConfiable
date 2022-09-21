using System.Collections.Generic;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public interface IRepositorioCambioRepuesto
    {
        CambioRepuesto AddCambioRepuesto(CambioRepuesto CambioRepuesto);
 
        CambioRepuesto UpdateCambioRepuesto(CambioRepuesto CambioRepuestoActualizado);

        IEnumerable<CambioRepuesto> GetAll();

        //IEnumerable<ListSegurosFull> GetAll();
/*         IEnumerable<Seguro> GetAllForVehiculo(int IdVehiculo);
 */
        CambioRepuesto GetCambioRepuestoId (int IdCambioRepuesto);

        //RevisionNiveles GetVehiculoPlaca (string Placa);

        //RevisionNiveles AddMechanic (Vehiculo MechanicUpdate);

        CambioRepuesto DeleteCambioRepuesto (int IdSeguro);
         
    }
}