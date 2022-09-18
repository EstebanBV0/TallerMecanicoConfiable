using System.Collections.Generic;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public interface IRepositorioNiveles
    {
        RevisionNiveles AddNiveles(RevisionNiveles niveles);
 
        RevisionNiveles UpdateNiveles(RevisionNiveles nivelesAcatualizados);

        IEnumerable<LisFullNivels> GetAll();
        IEnumerable<RevisionNiveles> GetAllForVehiculo(int IdVehiculo);

        RevisionNiveles GetNivelesId (int IdNiveles);

        //RevisionNiveles GetVehiculoPlaca (string Placa);

        //RevisionNiveles AddMechanic (Vehiculo MechanicUpdate);


        RevisionNiveles DeleteNiveles (int IdNiveles);

    }
}