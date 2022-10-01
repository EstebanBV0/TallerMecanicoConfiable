using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public class RepositorioDueño : IRepositorioDueño
    
    {
    private readonly AppContext _appContext;
    public RepositorioDueño(AppContext appContext)
    {
        _appContext = appContext;
    }

    Dueño IRepositorioDueño.AddDueño(Dueño dueño)
    {
        var Dueñoadicionado = _appContext.Dueños.Add(dueño);
        _appContext.SaveChanges();
        return Dueñoadicionado.Entity;
    }
     IEnumerable<Dueño> IRepositorioDueño.GetAll(){

        return _appContext.Dueños;

      }
      IEnumerable<Dueño> IRepositorioDueño.GetThisOwner(string filter )
      {
        //string filter = "x";
        var thisOwner = _appContext.Dueños.Where(p => p.Nombre.Contains( filter) ).ToList();
        return thisOwner;
      }
      Dueño IRepositorioDueño.GetDueñoId(int IdDueño)
        {
        return _appContext.Dueños.SingleOrDefault(p => p.IdDueño == IdDueño);

        }

    public Dueño UpdateDueño(Dueño dueñoactualizado)
        {
            Dueño dueño = _appContext.Dueños.SingleOrDefault(p => p.IdDueño == dueñoactualizado.IdDueño);
            if (dueño != null)
            {
                dueño.Nombre = dueñoactualizado.Nombre;
                dueño.Apellido = dueñoactualizado.Apellido;                
                dueño.FechaNacimiento = dueñoactualizado.FechaNacimiento;
                //dueño.Direccion = dueñoactualizado.Direccion;
                dueño.NumeroTelefono= dueñoactualizado.NumeroTelefono;                
                dueño.Email = dueñoactualizado.Email;
                dueño.Ciudad = dueñoactualizado.Ciudad;
                
                _appContext.SaveChanges();
            }
            return dueño;
        }

    public Dueño DeleteDueño(int IdDueño)
        {
            var Dueñoencontrado = _appContext.Dueños.FirstOrDefault(p => p.IdDueño == IdDueño);
            
            _appContext.Dueños.Remove(Dueñoencontrado);
            _appContext.SaveChanges();
            return Dueñoencontrado;
        }
    }
}