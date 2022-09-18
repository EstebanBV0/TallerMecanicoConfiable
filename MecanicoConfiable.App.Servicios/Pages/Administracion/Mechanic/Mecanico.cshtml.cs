using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;
using Microsoft.AspNetCore.Authorization;



namespace MecanicoConfiable.App.Servicios;

//[Authorize(Policy = "MustBelongADDepartment")]

public class MecanicoModel : PageModel
{
    private static IRepositorioMecanico _repoMecanico = new RepositorioMecanico(new Persistencia.AppContext());

    private readonly ILogger<MecanicoModel> _logger;

    public MecanicoModel(ILogger<MecanicoModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public Mecanico Mecanico { get; set; }
      public  IActionResult OnPost( )
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Mecanico != null) _repoMecanico.AddMecanico(Mecanico);
            return RedirectToPage("/Administracion/Administrador");
            
        } 
}
