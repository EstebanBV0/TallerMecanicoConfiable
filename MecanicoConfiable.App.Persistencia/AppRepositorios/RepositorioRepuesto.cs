using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public class RepositorioRepuesto : IRepositorioRepuesto
    
    {
    private readonly AppContext _appContext;
    public RepositorioRepuesto(AppContext appContext)
    {
        _appContext = appContext;
    }

    Repuesto IRepositorioRepuesto.AddRepuesto(Repuesto repuesto)
    {
        var Repuestoadicionado = _appContext.Repuestos.Add(repuesto);
        _appContext.SaveChanges();
        return Repuestoadicionado.Entity;
    }
     IEnumerable<Repuesto> IRepositorioRepuesto.GetAll(){

        return _appContext.Repuestos;

      }
      Repuesto IRepositorioRepuesto.GetRepuestoId(int IdRepuesto)
        {
        return _appContext.Repuestos.SingleOrDefault(p => p.IdRepuesto == IdRepuesto);

        }

    public Repuesto UpdateRepuesto(Repuesto repuestoactualizado)
        {
            Repuesto repuesto = _appContext.Repuestos.SingleOrDefault(p => p.IdRepuesto == repuestoactualizado.IdRepuesto);
            if (repuesto != null)
            {
                repuesto.Nombre = repuestoactualizado.Nombre;
                repuesto.Valor = repuestoactualizado.Valor;               
                          
                _appContext.SaveChanges();
            }
            return repuesto;
        }

    public Repuesto DeleteRepuesto(int IdRepuesto)
        {
            var Repuestoencontrado = _appContext.Repuestos.FirstOrDefault(p => p.IdRepuesto == IdRepuesto);
            
            _appContext.Repuestos.Remove(Repuestoencontrado);
            _appContext.SaveChanges();
            return Repuestoencontrado;
        }
    }
}