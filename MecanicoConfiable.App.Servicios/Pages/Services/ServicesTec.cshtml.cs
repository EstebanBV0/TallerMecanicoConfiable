using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Dominio;
using MecanicoConfiable.App.Persistencia;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MecanicoConfiable.App.Servicios
{
    
    public class ServicesTecModel : PageModel
    {
     private readonly IRepositorioServicios repositorioServicios;
     public IEnumerable<Servicio> TServicios {get;set;}



     public ServicesTecModel(IRepositorioServicios repositorioServicios)
     {
        this.repositorioServicios = repositorioServicios;
        
     }
        public void OnGet()
        {
            TServicios = repositorioServicios.GetAllForMech();
        }
    }
}
