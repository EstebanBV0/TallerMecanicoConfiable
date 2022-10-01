using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public class RepositorioAuxiliar : IRepositorioAuxiliar
    
    {
    private readonly AppContext _appContext;
    public RepositorioAuxiliar(AppContext appContext)
    {
        _appContext = appContext;
    }

    Auxiliar IRepositorioAuxiliar.AddAuxiliar(Auxiliar auxiliar)
    {
        var Auxiliaradicionado = _appContext.Auxiliares.Add(auxiliar);
        _appContext.SaveChanges();
        return Auxiliaradicionado.Entity;
    }
     IEnumerable<Auxiliar> IRepositorioAuxiliar.GetAll(){

        return _appContext.Auxiliares;

      }

      IEnumerable<Auxiliar> IRepositorioAuxiliar.GetThisAux(string filter )
      {
        //string filter = "x";
        var thisAux = _appContext.Auxiliares.Where(p => p.Nombre.Contains( filter) ).ToList();
        return thisAux;
      }
      Auxiliar IRepositorioAuxiliar.GetAuxiliarId(int IdAuxiliar)
        {
        return _appContext.Auxiliares.SingleOrDefault(p => p.IdAuxiliar == IdAuxiliar);

        }

    public Auxiliar UpdateAuxiliar(Auxiliar auxiliaractualizado)
        {
            Auxiliar auxiliar = _appContext.Auxiliares.SingleOrDefault(p => p.IdAuxiliar == auxiliaractualizado.IdAuxiliar);
            if (auxiliar != null)
            {
                auxiliar.Nombre = auxiliaractualizado.Nombre;
                auxiliar.Apellido = auxiliaractualizado.Apellido;                
                auxiliar.FechaNacimiento = auxiliaractualizado.FechaNacimiento;
                //auxiliar.Direccion = auxiliaractualizado.Direccion;
                auxiliar.NumeroTelefono= auxiliaractualizado.NumeroTelefono;                
                auxiliar.Email = auxiliaractualizado.Email;
                auxiliar.Ciudad = auxiliaractualizado.Ciudad;
                
                _appContext.SaveChanges();
            }
            return auxiliar;
        }

    public Auxiliar DeleteAuxiliar(int IdAuxiliar)
        {
            var auxiliarEncontrado = _appContext.Auxiliares.FirstOrDefault(p => p.IdAuxiliar == IdAuxiliar);
            
            _appContext.Auxiliares.Remove(auxiliarEncontrado);
            _appContext.SaveChanges();
            return auxiliarEncontrado;
        }
    }
}