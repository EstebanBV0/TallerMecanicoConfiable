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
      Vehiculo IRepositorioVehiculo.GetVehiculoId(int IdVehiculo)
        {
        return _appContext.Vehiculos.SingleOrDefault(p => p.IdVehiculo == IdVehiculo);

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