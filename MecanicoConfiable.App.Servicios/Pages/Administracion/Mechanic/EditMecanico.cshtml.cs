using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class EditMecanicoModel : PageModel
{
    private readonly IRepositorioMecanico _repoMecanico = new RepositorioMecanico(new Persistencia.AppContext());

    

    private readonly ILogger<EditMecanicoModel> _logger;

    public EditMecanicoModel(ILogger<EditMecanicoModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public Mecanico Mecanico { get; set; }
    
      public  IActionResult OnGet( int IdMecanico)
        {
            Mecanico = _repoMecanico.GetMecanicoId(IdMecanico);

            if(Mecanico==null){
                return RedirectToPage("./NotFound");
            }
            
             return Page();
            
        } 
        public IActionResult OnPost(){
              Mecanico  = _repoMecanico.UpdateMecanico(Mecanico);
              if (Mecanico == null){
                return RedirectToPage("./NotFound");
            }
              return RedirectToPage("./ListMecanicos"); 
        }
}
