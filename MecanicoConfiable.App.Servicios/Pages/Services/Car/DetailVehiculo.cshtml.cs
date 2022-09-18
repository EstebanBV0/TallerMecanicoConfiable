using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class DetailVehiculoModel : PageModel
{
    private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
    private readonly IRepositorioMecanico _repoMecanico = new RepositorioMecanico(new Persistencia.AppContext());

    

    private readonly ILogger<DetailVehiculoModel> _logger;

    public DetailVehiculoModel(ILogger<DetailVehiculoModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public Vehiculo Vehiculo { get; set; }
    public Mecanico Mecanico { get; set; }
    
      public  IActionResult OnGet( int IdVehiculo)
        {
            Vehiculo = _repoVehiculo.GetVehiculoId(IdVehiculo);
            Mecanico = _repoMecanico.GetMecanicoId(Vehiculo.IdMecanico);

            if(Vehiculo==null){
                return RedirectToPage("./NotFound");
            }
            
             return Page();
            
        } 
        /*public IActionResult OnPost(){
              Vehiculo  = _repoVehiculo.UpdateVehiculo(Vehiculo);
              if (Vehiculo == null){
                return RedirectToPage("./NotFound");
            }
              return RedirectToPage("./ListVehiculo"); 
        }*/
}
