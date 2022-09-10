using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class AdministradorModel : PageModel
{
    private readonly ILogger<AdministradorModel> _logger;
    private readonly IRepositorioPersonal repositorioPersonal;
    public IEnumerable<Personal> TPersonal {get;set;}

    public AdministradorModel(ILogger<AdministradorModel> logger, IRepositorioPersonal repositorioPersonal)
    {
        _logger = logger;
        this.repositorioPersonal = repositorioPersonal;
    }

  
    public void OnGet()
  
    {
        TPersonal = repositorioPersonal.GetAll();
        
        

    }
}
