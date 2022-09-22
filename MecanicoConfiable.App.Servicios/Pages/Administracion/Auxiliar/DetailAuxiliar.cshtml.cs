using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class DetailAuxiliarModel : PageModel
{
    //private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
    private readonly IRepositorioAuxiliar _repoAuxliar = new RepositorioAuxiliar(new Persistencia.AppContext());
    //private readonly IRepositorioDueño _repoDueño = new RepositorioDueño(new Persistencia.AppContext());

    

    private readonly ILogger<DetailAuxiliarModel> _logger;

    public DetailAuxiliarModel(ILogger<DetailAuxiliarModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    //public Vehiculo Vehiculo { get; set; }
    public Auxiliar Auxiliar { get; set; }
    //public Dueño Dueño { get; set; }
    
      public  IActionResult OnGet( int IdAuxiliar)
        {
            //Vehiculo = _repoVehiculo.GetVehiculoId(IdVehiculo);
            Auxiliar = _repoAuxliar.GetAuxiliarId(IdAuxiliar);
            //Dueño = _repoDueño.GetDueñoId(Vehiculo.IdDueño);

            if(Auxiliar==null){
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
