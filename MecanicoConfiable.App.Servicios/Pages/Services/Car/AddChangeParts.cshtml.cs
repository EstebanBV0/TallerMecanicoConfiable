using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class AddChangePartsModel : PageModel
{
    private static IRepositorioCambioRepuesto _repoCambioRepuesto = new RepositorioCambioRepuesto(new Persistencia.AppContext());
    private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
    private readonly IRepositorioRepuesto _repoRepuesto = new RepositorioRepuesto(new Persistencia.AppContext());

    private readonly ILogger<AddChangePartsModel> _logger;

    public AddChangePartsModel(ILogger<AddChangePartsModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public CambioRepuesto CambioRepuestos { get; set; }
    public IEnumerable<Vehiculo> Vehiculo { get; set; }
    public IEnumerable<Repuesto> Repuesto { get; set; }

    public Vehiculo Car { get; set; }

    public  IActionResult OnGet( int IdVehiculo)
        {
            Car = _repoVehiculo.GetVehiculoId( IdVehiculo);
            Repuesto = _repoRepuesto.GetAll();
            Vehiculo = _repoVehiculo.GetAll();

            if(Vehiculo==null){
                return RedirectToPage("./NotFound");
            }
            
             return Page();
            
        } 
      public  IActionResult OnPost( )
        {
            if (!ModelState.IsValid)
            {
                return RedirectToPage("/Services/Services");
            }
            if (CambioRepuestos != null) _repoCambioRepuesto.AddCambioRepuesto(CambioRepuestos);
            return RedirectToPage("/Services/Parts/ListCambioRepuestos");
            
        } 
}
