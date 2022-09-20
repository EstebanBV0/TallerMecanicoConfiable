using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public class RepositorioRepuestos : IRepositorioRepuestos
    
    {
    private readonly AppContext _appContext;
    public RepositorioRepuestos(AppContext appContext)
    {
        _appContext = appContext;
    }

    Repuesto IRepositorioRepuestos.AddRepuesto(Repuesto repuesto)
    {
        var repuestoAdicionado = _appContext.Repuestos.Add(repuesto);
        _appContext.SaveChanges();
        return repuestoAdicionado.Entity;
    }
     IEnumerable<Repuesto> IRepositorioRepuestos.GetAll(){

        return _appContext.Repuestos;

      }
      Repuesto IRepositorioRepuestos.GetRepuestoId(int IdRepuesto)
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
            var repuestoEncontrado = _appContext.Repuestos.FirstOrDefault(p => p.IdRepuesto == IdRepuesto);
            
            _appContext.Repuestos.Remove(repuestoEncontrado);
            _appContext.SaveChanges();
            return repuestoEncontrado;
        }
    }
}