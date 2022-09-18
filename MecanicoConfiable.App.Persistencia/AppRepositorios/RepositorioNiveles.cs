using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public class RepositorioNiveles : IRepositorioNiveles
    
    {
    private readonly AppContext _appContext;
    public RepositorioNiveles(AppContext appContext)
    {
        _appContext = appContext;
    }

    RevisionNiveles IRepositorioNiveles.AddNiveles(RevisionNiveles niveles)
    {
        var nivelesAdicionados = _appContext.RevisionNiveles.Add(niveles);
        _appContext.SaveChanges();
        return nivelesAdicionados.Entity;
    }
     IEnumerable<RevisionNiveles> IRepositorioNiveles.GetAll(){

        return _appContext.RevisionNiveles;

      }

      IEnumerable<RevisionNiveles> IRepositorioNiveles.GetAllForVehiculo(int IdVehiculo){

/*          var vehiculos = _appContext.Vehiculos.ToList().Select(x => x.IdMecanico == IdMecanico);
 */         var niveles = _appContext.RevisionNiveles.Where(s => s.IdVehiculo == IdVehiculo).ToList();
        return niveles;

      }


      RevisionNiveles IRepositorioNiveles.GetNivelesId(int IdNiveles)
        {
        return _appContext.RevisionNiveles.SingleOrDefault(p => p.IdNiveles == IdNiveles);

        }

   /*Vehiculo IRepositorioVehiculo.GetVehiculoPlaca(string Placa)
        {
        return _appContext.Vehiculos.SingleOrDefault(p => p.Placa == Placa);

        }
    public Vehiculo AddMechanic(Vehiculo vehiculoAct)
        {
            Vehiculo vehiculo = _appContext.Vehiculos.SingleOrDefault(p => p.Placa == vehiculoAct.Placa);
            if (vehiculo != null)
            {
               
                vehiculo.IdMecanico = vehiculoAct.IdMecanico;

                _appContext.SaveChanges();
            }
            return vehiculo;
        }
    */

    public RevisionNiveles UpdateNiveles(RevisionNiveles nivelesActualizados)
        {
            RevisionNiveles niveles = _appContext.RevisionNiveles.SingleOrDefault(p => p.IdNiveles == nivelesActualizados.IdNiveles);
            if (niveles != null)
            {
                niveles.FechaHora = nivelesActualizados.FechaHora;
                niveles.NivelAceite = nivelesActualizados.NivelAceite;
                niveles.NivelLiquidoFrenos = nivelesActualizados.NivelLiquidoFrenos;
                niveles.NivelRefrigerante = nivelesActualizados.NivelRefrigerante;
                niveles.NivelLiquidDireccion= nivelesActualizados.NivelLiquidDireccion;
                niveles.IdVehiculo = nivelesActualizados.IdVehiculo;
               
                _appContext.SaveChanges();
            }
            return niveles;
        }

    public RevisionNiveles DeleteNiveles(int IdNiveles)
        {
            var nivelesEncontrados = _appContext.RevisionNiveles.FirstOrDefault(p => p.IdNiveles == IdNiveles);
            
            _appContext.RevisionNiveles.Remove(nivelesEncontrados);
            _appContext.SaveChanges();
            return nivelesEncontrados;
        }
    }
}