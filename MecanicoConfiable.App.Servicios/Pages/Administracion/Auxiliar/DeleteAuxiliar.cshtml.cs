using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MecanicoConfiable.App.Persistencia;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Servicios;

    public class DeleteAuxiliarModel : PageModel

    {
    private readonly IRepositorioAuxiliar _repoAuxiliar = new RepositorioAuxiliar(new Persistencia.AppContext());

    private readonly ILogger<DeleteAuxiliarModel> _logger;

    public DeleteAuxiliarModel(ILogger<DeleteAuxiliarModel> logger)
    {
        _logger = logger;
    }

      [BindProperty]
       public Auxiliar Auxiliar { get; set; }
        public IActionResult OnGet(int IdAuxiliar)
        {
            Auxiliar = _repoAuxiliar.GetAuxiliarId(IdAuxiliar);
            if (Auxiliar == null){
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
        public IActionResult Onpost(){
            Auxiliar auxiliareliminado = _repoAuxiliar.DeleteAuxiliar(Auxiliar.IdAuxiliar);
              if (auxiliareliminado == null){
                return RedirectToPage("./NotFound");
            }
              return RedirectToPage("./ListAuxiliar");   
                   }
    }

