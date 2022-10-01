using System.Collections.Generic;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public interface IRepositorioRepuesto
    {
        Repuesto AddRepuesto(Repuesto repuesto);
 
        Repuesto UpdateRepuesto(Repuesto repuesto);

        IEnumerable<Repuesto> GetAll();
        
        IEnumerable<Repuesto> GetThisRep(string Rep);

        Repuesto GetRepuestoId (int IdRepuesto);

        Repuesto DeleteRepuesto (int IdRepuesto);

    }
}