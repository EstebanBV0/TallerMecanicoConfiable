using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MecanicoConfiable.App.Servicios
{
[Authorize(Policy = "MustBelongADDepartment")]
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
}