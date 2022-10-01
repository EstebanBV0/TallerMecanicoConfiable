using System.Collections.Generic;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public interface IRepositorioAuxiliar
    {
        Auxiliar AddAuxiliar(Auxiliar auxiliar);
 
        Auxiliar UpdateAuxiliar(Auxiliar auxiliar);

        IEnumerable<Auxiliar> GetAll();
        IEnumerable<Auxiliar> GetThisAux(string Aux);

        Auxiliar GetAuxiliarId (int IdAuxiliar);

        Auxiliar DeleteAuxiliar (int IdAuxiliar);

    }
}