using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class DetailDueñoModel : PageModel
{
    //private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
    //private readonly IRepositorioMecanico _repoMecanico = new RepositorioMecanico(new Persistencia.AppContext());
    private readonly IRepositorioDueño _repoDueño = new RepositorioDueño(new Persistencia.AppContext());

    

    private readonly ILogger<DetailDueñoModel> _logger;

    public DetailDueñoModel(ILogger<DetailDueñoModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    //public Vehiculo Vehiculo { get; set; }
    //public Mecanico Mecanico { get; set; }
    public Dueño Dueño { get; set; }
    
      public  IActionResult OnGet( int IdDueño)
        {
            //Vehiculo = _repoVehiculo.GetVehiculoId(IdVehiculo);
            //Mecanico = _repoMecanico.GetMecanicoId(Vehiculo.IdMecanico);
            Dueño = _repoDueño.GetDueñoId(IdDueño);

            if(Dueño==null){
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
