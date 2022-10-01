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
    public string filter = null;
     /* public  void OnGet( )
        {
         Vehiculos = _repoVehiculo.GetAll();
         //Vehiculos = _repoVehiculo.GetThisCar();
        } */

      public  IActionResult OnGet( string Pla)
        {            
            filter = Pla;

            if(Pla==null){
                 Vehiculos = _repoVehiculo.GetAll();
            }else
            {              
              Vehiculos = _repoVehiculo.GetThisCar(Pla);
            }            
             return Page();            
        } 

       
 
}
