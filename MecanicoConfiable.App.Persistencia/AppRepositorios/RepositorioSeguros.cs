using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using MecanicoConfiable.App.Dominio;


namespace MecanicoConfiable.App.Persistencia
{
    public class RepositorioSeguros :IRepositorioSeguros
    {
    private readonly AppContext _appContext;
    public RepositorioSeguros(AppContext appContext)
    {
        _appContext = appContext;
    }

    Seguro IRepositorioSeguros.AddSeguro(Seguro segur)
    {
        var seguroadicionado = _appContext.Seguros.Add(segur);
        _appContext.SaveChanges();
        return seguroadicionado.Entity;
    }
     IEnumerable<ListSegurosFull> IRepositorioSeguros.GetAll(){

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

      }

     /* IEnumerable<Seguro> IRepositorioSeguros.GetThisSeg(string filter )
      {
        //string filter = "x";
        return _appContext.Seguros.Where(p => p.Vehiculo.Any(s=> s.Placa==filter)).ToList();
        //return thisMec;
      }*/

      Seguro IRepositorioSeguros.GetSegurosId(int IdSeguro)
        {
        return _appContext.Seguros.SingleOrDefault(p => p.IdSeguro == IdSeguro);

        }

    public Seguro UpdateSeguro(Seguro SegurosActualizado)
        {
            Seguro segur = _appContext.Seguros.SingleOrDefault(p => p.IdSeguro == SegurosActualizado.IdSeguro);
            if (segur != null)
            {
                segur.TipoSeguro = SegurosActualizado.TipoSeguro;
                segur.FechaCompra = SegurosActualizado.FechaCompra;
                segur.FechaInicial = SegurosActualizado.FechaInicial;
                segur.FechaFinal = SegurosActualizado.FechaFinal;
                segur.ValorSeguro= SegurosActualizado.ValorSeguro;
                segur.IdVehiculo = SegurosActualizado.IdVehiculo;
               
                _appContext.SaveChanges();
            }
            return segur;
        }

    public Seguro DeleteSeguro(int IdSeguro)
        {
            var SeguroEncontrado = _appContext.Seguros.FirstOrDefault(p => p.IdSeguro == IdSeguro);
            
            _appContext.Seguros.Remove(SeguroEncontrado);
            _appContext.SaveChanges();
            return SeguroEncontrado;
        }
    }
}