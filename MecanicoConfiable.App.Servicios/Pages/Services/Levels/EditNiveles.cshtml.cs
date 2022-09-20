using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class EditNiveles : PageModel
{
    private readonly IRepositorioNiveles _repoNiveles = new RepositorioNiveles(new Persistencia.AppContext());

    private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
  

    private readonly ILogger<EditNiveles> _logger;

    public EditNiveles(ILogger<EditNiveles> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public RevisionNiveles Niveles { get; set; }
    public IEnumerable<Vehiculo> Vehiculo { get; set; }

    
      public  IActionResult OnGet( int IdNiveles)
        {
            Niveles = _repoNiveles.GetNivelesId(IdNiveles);
            Vehiculo = _repoVehiculo.GetAll();

            if(Niveles==null){
                return RedirectToPage("./NotFound");
            }
            
             return Page();
            
        } 
        public IActionResult OnPost(){
              Niveles  = _repoNiveles.UpdateNiveles(Niveles);
              if (Niveles == null){
                return RedirectToPage("./NotFound");
            }
              return RedirectToPage("./ListNiveles"); 
        }
}
