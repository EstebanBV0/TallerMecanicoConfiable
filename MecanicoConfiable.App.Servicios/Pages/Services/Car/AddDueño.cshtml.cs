using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios
{
    public class AddDueñoModel : PageModel
    {
    private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
    private readonly IRepositorioMecanico _repoMecanico = new RepositorioMecanico(new Persistencia.AppContext());
    private readonly IRepositorioDueño _repoDueño = new RepositorioDueño(new Persistencia.AppContext());

    private readonly ILogger<EditDueñoModel> _logger;

    public AddDueñoModel(ILogger<EditDueñoModel> logger)
    {
        _logger = logger;
    }
      
    [BindProperty]
    public Vehiculo Vehiculo { get; set; }
    public IEnumerable<Dueño> Dueño { get; set; }
    
      public  IActionResult OnGet( string Placa)
        {
            //Mecanico = _repoMecanico.GetAll();
            Dueño = _repoDueño.GetAll();
            Vehiculo = _repoVehiculo.GetVehiculoPlaca(Placa);

            if(Vehiculo==null){
                return RedirectToPage("./NotFound");
            }
            
             return Page();
            
        } 
        public IActionResult OnPost(){
              Vehiculo  = _repoVehiculo.AddDueño(Vehiculo);
              if (Vehiculo == null){
                return RedirectToPage("./ListVehiculo");
            }
              return RedirectToPage("./ListVehiculo"); 
        }
    }
}
