using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios
{
    public class AddMecanicoModel : PageModel
    {
    private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
    private readonly IRepositorioMecanico _repoMecanico = new RepositorioMecanico(new Persistencia.AppContext());
    private readonly ILogger<EditMecanicoModel> _logger;

    public AddMecanicoModel(ILogger<EditMecanicoModel> logger)
    {
        _logger = logger;
    }
      
    [BindProperty]
    public Vehiculo Vehiculo { get; set; }
    public IEnumerable<Mecanico> Mecanico { get; set; }
    
      public  IActionResult OnGet( string Placa)
        {
            Mecanico = _repoMecanico.GetAll();
            Vehiculo = _repoVehiculo.GetVehiculoPlaca(Placa);

            if(Vehiculo==null){
                return RedirectToPage("./NotFound");
            }
            
             return Page();
            
        } 
        public IActionResult OnPost(){
              Vehiculo  = _repoVehiculo.AddMechanic(Vehiculo);
              if (Vehiculo == null){
                return RedirectToPage("./ListVehiculo");
            }
              return RedirectToPage("./ListVehiculo"); 
        }
    }
}
