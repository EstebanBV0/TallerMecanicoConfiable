using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public class RepositorioMecanico : IRepositorioMecanico
    
    {
    private readonly AppContext _appContext;
    public RepositorioMecanico(AppContext appContext)
    {
        _appContext = appContext;
    }

    Mecanico IRepositorioMecanico.AddMecanico(Mecanico mecanico)
    {
        var Mecanicoadicionado = _appContext.Mecanicos.Add(mecanico);
        _appContext.SaveChanges();
        return Mecanicoadicionado.Entity;
    }
     IEnumerable<Mecanico> IRepositorioMecanico.GetAll(){

        return _appContext.Mecanicos;

      }

      IEnumerable<Mecanico> IRepositorioMecanico.GetThisMec(string filter )
      {
        //string filter = "x";
        var thisMec = _appContext.Mecanicos.Where(p => p.Nombre.Contains( filter) ).ToList();
        return thisMec;
      }

      Mecanico IRepositorioMecanico.GetMecanicoId(int IdMecanico)
        {
        return _appContext.Mecanicos.SingleOrDefault(p => p.IdMecanico == IdMecanico);

        }

    public Mecanico UpdateMecanico(Mecanico mecanicoactualizado)
        {
            Mecanico mecanicoo = _appContext.Mecanicos.SingleOrDefault(p => p.IdMecanico == mecanicoactualizado.IdMecanico);
            if (mecanicoo != null)
            {
                mecanicoo.Nombre = mecanicoactualizado.Nombre;
                mecanicoo.Apellido = mecanicoactualizado.Apellido;
                mecanicoo.Direccion = mecanicoactualizado.Direccion;
                mecanicoo.NivelEstudio = mecanicoactualizado.NivelEstudio;
                mecanicoo.NumeroTelefono= mecanicoactualizado.NumeroTelefono;
                mecanicoo.FechaNacimiento = mecanicoactualizado.FechaNacimiento;
                _appContext.SaveChanges();
            }
            return mecanicoo;
        }

    public Mecanico DeleteMedico(int IdMecanico)
        {
            var Mecanicoencontrado = _appContext.Mecanicos.FirstOrDefault(p => p.IdMecanico == IdMecanico);
            
            _appContext.Mecanicos.Remove(Mecanicoencontrado);
            _appContext.SaveChanges();
            return Mecanicoencontrado;
        }
    }
}