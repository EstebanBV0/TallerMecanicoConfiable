using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class EditCambioRepuesto : PageModel
{
    private readonly IRepositorioCambioRepuesto _repoCambioRepuesto = new RepositorioCambioRepuesto(new Persistencia.AppContext());
    private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
    private readonly IRepositorioRepuesto _repoRepuesto = new RepositorioRepuesto(new Persistencia.AppContext());


    private readonly ILogger<EditCambioRepuesto> _logger;

    public EditCambioRepuesto(ILogger<EditCambioRepuesto> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public CambioRepuesto CambioRepuesto { get; set; }
    public IEnumerable<Vehiculo> Vehiculo { get; set; }
    public IEnumerable <Repuesto> Repuesto { get; set; }

    
      public  IActionResult OnGet( int IdCambioRepuesto)
        {
            CambioRepuesto = _repoCambioRepuesto.GetCambioRepuestoId(IdCambioRepuesto);
            Vehiculo = _repoVehiculo.GetAll();
            Repuesto = _repoRepuesto.GetAll();

            if(CambioRepuesto==null){
                return RedirectToPage("./NotFound");
            }
            
             return Page();
            
        } 
        public IActionResult OnPost(){
              CambioRepuesto  = _repoCambioRepuesto.UpdateCambioRepuesto(CambioRepuesto);
              if (CambioRepuesto == null){
                return RedirectToPage("./NotFound");
            }
              return RedirectToPage("./ListCambioRepuestos"); 
        }
}
