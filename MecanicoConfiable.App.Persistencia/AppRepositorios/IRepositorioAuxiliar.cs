using System.Collections.Generic;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public interface IRepositorioAuxiliar
    {
        Auxiliar AddAuxiliar(Auxiliar auxiliar);
 
        Auxiliar UpdateAuxiliar(Auxiliar auxiliar);

        IEnumerable<Auxiliar> GetAll();

        Auxiliar GetAuxiliarId (int IdAuxiliar);

        Auxiliar DeleteAuxiliar (int IdAuxiliar);

    }
}