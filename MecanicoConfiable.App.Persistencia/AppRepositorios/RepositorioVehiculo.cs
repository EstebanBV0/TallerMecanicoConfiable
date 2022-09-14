using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public class RepositorioVehiculo : IRepositorioVehiculo
    
    {
    private readonly AppContext _appContext;
    public RepositorioVehiculo(AppContext appContext)
    {
        _appContext = appContext;
    }

    Vehiculo IRepositorioVehiculo.AddVehiculo(Vehiculo vehiculo)
    {
        var vehiculoAdicionado = _appContext.Vehiculos.Add(vehiculo);
        _appContext.SaveChanges();
        return vehiculoAdicionado.Entity;
    }
     IEnumerable<Vehiculo> IRepositorioVehiculo.GetAll(){

        return _appContext.Vehiculos;

      }

      IEnumerable<Vehiculo> IRepositorioVehiculo.GetAllForMechanich(int IdMecanico){

/*          var vehiculos = _appContext.Vehiculos.ToList().Select(x => x.IdMecanico == IdMecanico);
 */         var vehiculos = _appContext.Vehiculos.Where(s => s.IdMecanico == IdMecanico).ToList();
        return vehiculos;

      }


      Vehiculo IRepositorioVehiculo.GetVehiculoId(int IdVehiculo)
        {
        return _appContext.Vehiculos.SingleOrDefault(p => p.IdVehiculo == IdVehiculo);

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
                vehiculo.Seguro = vehiculoActualizado.Seguro;
                vehiculo.Dueño = vehiculoActualizado.Dueño;
                vehiculo.Conductor = vehiculoActualizado.Conductor;
                vehiculo.RevisionNiveles = vehiculoActualizado.RevisionNiveles;
                vehiculo.CambioRepuesto = vehiculoActualizado.CambioRepuesto;
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