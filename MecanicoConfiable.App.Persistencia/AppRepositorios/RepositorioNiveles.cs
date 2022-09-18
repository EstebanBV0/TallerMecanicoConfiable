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

        return _appContext.Niveles;

      }

      IEnumerable<RevisionNiveles> IRepositorioNiveles.GetAllForVehiculo(int IdVehiculo){

/*          var vehiculos = _appContext.Vehiculos.ToList().Select(x => x.IdMecanico == IdMecanico);
 */         var niveles = _appContext.RevisionNiveles.Where(s => s.IdVehiculo == IdVehiculo).ToList();
        return niveles;

      }


      RevisionNiveles IRepositorioNiveles.GetNivelesId(int IdNiveles)
        {
        return _appContext.RevisionNiveles.SingleOrDefault(p => p.IdVehiculo == IdVehiculo);

        }

   Vehiculo IRepositorioVehiculo.GetVehiculoPlaca(string Placa)
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
    

    public Vehiculo UpdateVehiculo(Vehiculo vehiculoActualizado)
        {
            Vehiculo vehiculo = _appContext.Vehiculos.SingleOrDefault(p => p.IdVehiculo == vehiculoActualizado.IdVehiculo);
            if (vehiculo != null)
            {
                vehiculo.Placa = vehiculoActualizado.Placa;
                vehiculo.Tipo = vehiculoActualizado.Tipo;
                vehiculo.Marca = vehiculoActualizado.Marca;
                vehiculo.Modelo = vehiculoActualizado.Modelo;
                vehiculo.NumeroPasajeros= vehiculoActualizado.NumeroPasajeros;
                vehiculo.PaisOrigen = vehiculoActualizado.PaisOrigen;
                vehiculo.DescripcionAdicional = vehiculoActualizado.DescripcionAdicional;
                //vehiculo.Seguro = vehiculoActualizado.Seguro;
                vehiculo.IdDueño = vehiculoActualizado.IdDueño;
                //vehiculo.Conductor = vehiculoActualizado.Conductor;
                //vehiculo.RevisionNiveles = vehiculoActualizado.RevisionNiveles;
                //vehiculo.CambioRepuesto = vehiculoActualizado.CambioRepuesto;
                vehiculo.IdMecanico = vehiculoActualizado.IdMecanico;

                _appContext.SaveChanges();
            }
            return vehiculo;
        }

    public Vehiculo DeleteVehiculo(int IdVehiculo)
        {
            var vehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(p => p.IdVehiculo == IdVehiculo);
            
            _appContext.Vehiculos.Remove(vehiculoEncontrado);
            _appContext.SaveChanges();
            return vehiculoEncontrado;
        }
    }
}