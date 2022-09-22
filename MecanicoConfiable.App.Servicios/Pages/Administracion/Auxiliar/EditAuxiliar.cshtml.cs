using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

public class EditAuxiliarModel : PageModel
{
    private readonly IRepositorioAuxiliar _repoAuxiliar = new RepositorioAuxiliar(new Persistencia.AppContext());

    

    private readonly ILogger<EditAuxiliarModel> _logger;

    public EditAuxiliarModel(ILogger<EditAuxiliarModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public Auxiliar Auxiliar { get; set; }
    
      public  IActionResult OnGet( int IdAuxiliar)
        {
            Auxiliar = _repoAuxiliar.GetAuxiliarId(IdAuxiliar);

            if(Auxiliar==null){
                return RedirectToPage("./NotFound");
            }
            
             return Page();
            
        } 
        public IActionResult OnPost(){
              Auxiliar  = _repoAuxiliar.UpdateAuxiliar(Auxiliar);
              if (Auxiliar == null){
                return RedirectToPage("./NotFound");
            }
              return RedirectToPage("./ListAuxiliar"); 
        }
}
