using System.Collections.Generic;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public interface IRepositorioDueño
    {
        Dueño AddDueño(Dueño dueño);
 
        Dueño UpdateDueño(Dueño dueño);

        IEnumerable<Dueño> GetAll();
        IEnumerable<Dueño> GetThisOwner(string Owner);

        Dueño GetDueñoId (int IdDueño);

        Dueño DeleteDueño (int IdDueño);

    }
}