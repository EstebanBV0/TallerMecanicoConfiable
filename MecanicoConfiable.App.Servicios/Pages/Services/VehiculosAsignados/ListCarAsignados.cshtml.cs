using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Dominio;
using MecanicoConfiable.App.Persistencia;

namespace MecanicoConfiable.App.Servicios.Pages
{
    public class ListCarAsignadosModel : PageModel
    {
    private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());

        private readonly ILogger<ListCarAsignadosModel> _logger;

        public ListCarAsignadosModel(ILogger<ListCarAsignadosModel> logger)
        {
            _logger = logger;
        }

       

        [BindProperty]
        public IEnumerable<Vehiculo> Vehiculos { get; set; }
        public void OnGet(int IdMecanico)
        {
            Vehiculos = _repoVehiculo.GetAllForMechanich( IdMecanico);
        }
    }
}
