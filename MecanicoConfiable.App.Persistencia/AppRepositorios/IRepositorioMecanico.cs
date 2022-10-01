using System.Collections.Generic;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public interface IRepositorioMecanico
    {
        Mecanico AddMecanico(Mecanico mecanico);
 
        Mecanico UpdateMecanico(Mecanico mecanicoactualizado);

        IEnumerable<Mecanico> GetAll();
        IEnumerable<Mecanico> GetThisMec(string Mec);

        Mecanico GetMecanicoId (int IdMecanico);

         Mecanico DeleteMedico (int IdMecanico);

    }
}