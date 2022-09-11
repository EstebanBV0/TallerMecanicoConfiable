using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class ListVehiculoModel : PageModel
{
    private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());

    private readonly ILogger<ListVehiculoModel> _logger;

    public ListVehiculoModel(ILogger<ListVehiculoModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public IEnumerable<Vehiculo> Vehiculos { get; set; }
      public  void OnGet( )
        {
         Vehiculos = _repoVehiculo.GetAll();
        } 
}
