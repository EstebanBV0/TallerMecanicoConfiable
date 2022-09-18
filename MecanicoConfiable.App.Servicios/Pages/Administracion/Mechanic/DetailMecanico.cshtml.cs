using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class DetailMecanicoModel : PageModel
{
    //private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
    private readonly IRepositorioMecanico _repoMecanico = new RepositorioMecanico(new Persistencia.AppContext());
    //private readonly IRepositorioDueño _repoDueño = new RepositorioDueño(new Persistencia.AppContext());

    

    private readonly ILogger<DetailMecanicoModel> _logger;

    public DetailMecanicoModel(ILogger<DetailMecanicoModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    //public Vehiculo Vehiculo { get; set; }
    public Mecanico Mecanico { get; set; }
    //public Dueño Dueño { get; set; }
    
      public  IActionResult OnGet( int IdMecanico)
        {
            //Vehiculo = _repoVehiculo.GetVehiculoId(IdVehiculo);
            Mecanico = _repoMecanico.GetMecanicoId(IdMecanico);
            //Dueño = _repoDueño.GetDueñoId(Vehiculo.IdDueño);

            if(Mecanico==null){
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
