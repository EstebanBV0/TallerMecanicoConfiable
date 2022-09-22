using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class DetailNivelesModel : PageModel
{
    private static IRepositorioNiveles _reponiveles = new RepositorioNiveles(new Persistencia.AppContext());
    private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());

    private readonly ILogger<DetailNivelesModel> _logger;

    public DetailNivelesModel(ILogger<DetailNivelesModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public RevisionNiveles Niveles { get; set; }
    public Vehiculo Vehiculo { get; set; }

    public  IActionResult OnGet( int IdNiveles)
        {
            //Mecanico = _repoMecanico.GetAll();
            Niveles = _reponiveles.GetNivelesId(IdNiveles);
            Vehiculo = _repoVehiculo.GetVehiculoId(Niveles.IdVehiculo);

            if(Niveles==null){
                return RedirectToPage("./NotFound");
            }
            
             return Page();
            
        } 
      
}
