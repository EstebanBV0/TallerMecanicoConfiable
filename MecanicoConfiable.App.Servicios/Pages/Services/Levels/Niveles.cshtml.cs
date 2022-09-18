using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class NivelesModel : PageModel
{
    private static IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());

    private readonly ILogger<NivelesModel> _logger;

    public NivelesModel(ILogger<NivelesModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public Vehiculo Vehiculo { get; set; }
      public  IActionResult OnPost( )
        {
            if (!ModelState.IsValid)
            {
                return RedirectToPage("./ListVehiculo");
            }
            if (Vehiculo != null) _repoVehiculo.AddVehiculo(Vehiculo);
            return RedirectToPage("./ListVehiculo");
            
        } 
}
