using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class EditCarModel : PageModel
{
    private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());

    private readonly IRepositorioMecanico _repoMecanico = new RepositorioMecanico(new Persistencia.AppContext());

    private readonly IRepositorioDueño _repoDueño = new RepositorioDueño(new Persistencia.AppContext());

    private readonly ILogger<EditCarModel> _logger;

    public EditCarModel(ILogger<EditCarModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public Vehiculo Vehiculo { get; set; }
    public IEnumerable<Mecanico> Mecanico { get; set; }
    public IEnumerable<Dueño> Dueño { get; set; }


    
      public  IActionResult OnGet( int IdVehiculo)
        {
            
            Vehiculo = _repoVehiculo.GetVehiculoId(IdVehiculo);
            Mecanico = _repoMecanico.GetAll();
            Dueño = _repoDueño.GetAll();


            if(Vehiculo==null){
                return RedirectToPage("./NotFound");
            }
            
             return Page();
            
        } 
        public IActionResult OnPost(){
              Vehiculo  = _repoVehiculo.UpdateVehiculo(Vehiculo);
              if (Vehiculo == null){
                return RedirectToPage("./NotFound");
            }
              return RedirectToPage("./ListVehiculo"); 
        }
}
