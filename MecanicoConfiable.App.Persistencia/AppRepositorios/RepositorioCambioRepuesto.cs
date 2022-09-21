using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using MecanicoConfiable.App.Dominio;


namespace MecanicoConfiable.App.Persistencia
{
    public class RepositorioCambioRepuesto : IRepositorioCambioRepuesto
    {
    private readonly AppContext _appContext;
    public RepositorioCambioRepuesto(AppContext appContext)
    {
        _appContext = appContext;
    }

    CambioRepuesto IRepositorioCambioRepuesto.AddCambioRepuesto(CambioRepuesto CambioRepuesto)
    {
        var cambioSeguroAdicionado = _appContext.CambioRepuestos.Add(CambioRepuesto);
        _appContext.SaveChanges();
        return cambioSeguroAdicionado.Entity;
    }

    IEnumerable<CambioRepuesto> IRepositorioCambioRepuesto.GetAll(){

        return _appContext.CambioRepuestos;

      }
     /*IEnumerable<ListSegurosFull> IRepositorioSeguros.GetAll(){

            var  query =     from a in _appContext.Seguros
                            join s in _appContext.Vehiculos on a.IdVehiculo equals s.IdVehiculo
                            select new ListSegurosFull { 
                            IdSeguro = a.IdSeguro, 
                            IdVehiculo = a.IdVehiculo, 
                            TipoSeguro = a.TipoSeguro,
                            FechaCompra = a.FechaCompra, 
                            FechaInicial = a.FechaInicial, 
                            FechaFinal = a.FechaFinal, 
                            ValorSeguro = a.ValorSeguro,
                            Placa = s.Placa };

            return query.ToList();

      }*/

      CambioRepuesto IRepositorioCambioRepuesto.GetCambioRepuestoId(int IdCambioRepuesto)
        {
        return _appContext.CambioRepuestos.SingleOrDefault(p => p.IdCambioRepuesto == IdCambioRepuesto);

        }

    public CambioRepuesto UpdateCambioRepuesto(CambioRepuesto CambioRepuestoActualizado)
        {
            CambioRepuesto CSact = _appContext.CambioRepuestos.SingleOrDefault(p => p.IdCambioRepuesto == CambioRepuestoActualizado.IdCambioRepuesto);
            if (CSact != null)
            {
                CSact.FechaHora = CambioRepuestoActualizado.FechaHora;
                CSact.IdRepuesto = CambioRepuestoActualizado.IdRepuesto;
                CSact.IdVehiculo = CambioRepuestoActualizado.IdVehiculo;

                  
                _appContext.SaveChanges();
            }
            return CSact;
        }

    public CambioRepuesto DeleteCambioRepuesto(int IdCambioRepuesto)
        {
            var CambioRepuestoEncontrado = _appContext.CambioRepuestos.FirstOrDefault(p => p.IdCambioRepuesto == IdCambioRepuesto);
            
            _appContext.CambioRepuestos.Remove(CambioRepuestoEncontrado);
            _appContext.SaveChanges();
            return CambioRepuestoEncontrado;
        }
    }
}