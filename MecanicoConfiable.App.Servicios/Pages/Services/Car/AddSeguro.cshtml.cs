using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios
{
    public class AddSeguroModel : PageModel
    {
    private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
    private readonly IRepositorioSeguros _repoSeguro = new RepositorioSeguros(new Persistencia.AppContext());

    private readonly ILogger<AddSeguroModel> _logger;

    public AddSeguroModel(ILogger<AddSeguroModel> logger)
    {
        _logger = logger;
    }
      
    [BindProperty]
    public Seguro Seguro { get; set; }
    
    [BindProperty]
    public Vehiculo Vehiculo { get; set; }
    
      public  IActionResult OnGet( int IdVehiculo)
        {
            Vehiculo = _repoVehiculo.GetVehiculoId(IdVehiculo);

            if(Vehiculo==null){
                return RedirectToPage("./NotFound");
            }
            
             return Page();
            
        } 
        public IActionResult OnPost(){
              Seguro  = _repoSeguro.AddSeguro(Seguro);
              if (Seguro == null){
                return RedirectToPage("./ListVehiculo");
            }
              return RedirectToPage("/Services/SegurosVehiculos/ListSegurosActuales"); 
        }
    }
}
