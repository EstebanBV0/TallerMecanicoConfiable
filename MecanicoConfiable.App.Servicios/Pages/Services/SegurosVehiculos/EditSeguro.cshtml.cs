using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class EditSeguroModel : PageModel
{
    private readonly IRepositorioSeguros _repoSeguro = new RepositorioSeguros(new Persistencia.AppContext());
    private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());

    

    private readonly ILogger<EditSeguroModel> _logger;

    public EditSeguroModel(ILogger<EditSeguroModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public Seguro Seguro { get; set; }
    public IEnumerable<Vehiculo> Vehiculo { get; set; }

    
      public  IActionResult OnGet( int IdSeguro)
        {
            Seguro = _repoSeguro.GetSegurosId(IdSeguro);
            Vehiculo = _repoVehiculo.GetAll();

            if(Seguro==null){
                return RedirectToPage("./NotFound");
            }
            
             return Page();
            
        } 
        public IActionResult OnPost(){
              Seguro  = _repoSeguro.UpdateSeguro(Seguro);
              if (Seguro == null){
                return RedirectToPage("./NotFound");
            }
              return RedirectToPage("./ListSegurosActuales"); 
        }
}
