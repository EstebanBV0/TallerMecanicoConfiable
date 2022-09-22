using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

    public class DeleVehiculoModel : PageModel

    {
    private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());

    private readonly ILogger<DeleVehiculoModel> _logger;

    public DeleVehiculoModel(ILogger<DeleVehiculoModel> logger)
    {
        _logger = logger;
    }

      [BindProperty]
       public Vehiculo Vehiculo { get; set; }
        public IActionResult OnGet(int IdVehiculo)
        {
            Vehiculo = _repoVehiculo.GetVehiculoId(IdVehiculo);
            if (Vehiculo == null){
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
        public IActionResult Onpost(){
            Vehiculo vehiculoeliminado = _repoVehiculo.DeleteVehiculo(Vehiculo.IdVehiculo);
              if (vehiculoeliminado == null){
                return RedirectToPage("./NotFound");
            }
              return RedirectToPage("./ListVehiculo");   
                   }
    }

