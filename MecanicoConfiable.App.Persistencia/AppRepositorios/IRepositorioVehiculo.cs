using System.Collections.Generic;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public interface IRepositorioVehiculo
    {
        Vehiculo AddVehiculo(Vehiculo vehiculo);
 
        Vehiculo UpdateVehiculo(Vehiculo vehiculoActualizado);

        IEnumerable<Vehiculo> GetAll();
        IEnumerable<Vehiculo> GetAllForMechanich(int IdMecanico);

        Vehiculo GetVehiculoId (int IdVehiculo);

        Vehiculo GetVehiculoPlaca (string Placa);

        Vehiculo AddMechanic (Vehiculo MechanicUpdate);


        Vehiculo DeleteVehiculo (int IdVehiculo);

    }
}