using System.Collections.Generic;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public interface IRepositorioVehiculo
    {
        Vehiculo AddVehiculo(Vehiculo vehiculo);
 
        Vehiculo UpdateVehiculo(Vehiculo vehiculoActualizado);

        IEnumerable<Vehiculo> GetAll();

        Vehiculo GetVehiculoId (int IdVehiculo);

        Vehiculo DeleteVehiculo (int IdVehiculo);

    }
}