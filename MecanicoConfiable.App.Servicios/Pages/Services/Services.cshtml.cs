using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Dominio;
using MecanicoConfiable.App.Persistencia;


namespace MecanicoConfiable.App.Servicios
{
    public class ServicesModel : PageModel
    {
     private readonly IRepositorioServicios repositorioServicios;
     public IEnumerable<Servicio> TServicios {get;set;}



     public ServicesModel(IRepositorioServicios repositorioServicios)
     {
        this.repositorioServicios = repositorioServicios;
        
     }

        public void OnGet()
        {
            TServicios = repositorioServicios.GetAll();
        }
    }
}
