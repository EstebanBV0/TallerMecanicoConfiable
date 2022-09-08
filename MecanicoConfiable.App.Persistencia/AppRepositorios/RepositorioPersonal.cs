using System.Collections.Generic;
using MecanicoConfiable.App.Dominio;


namespace MecanicoConfiable.App.Persistencia

{

    public class RepositorioPersonal : IRepositorioPersonal
    {
        List<Personal> TodoPersonal;
        
        public RepositorioPersonal(){

            
            TodoPersonal =  new List<Personal>{ new Personal { 
                    Titulo = "Mecanico",
                    Descripcion = "Personal encargado del mantenimiento y la reparacion de los automoviles",
                    ImagenUrl = "/imagenes/Mecanico.png",
                    Link = "/Mechanic/Mecanico"},
                    new Personal { 
                    Titulo = "Auxiliar",
                    Descripcion = "Personal encargado de la administracion",
                    ImagenUrl = "/imagenes/auxiliar.png",
                    Link = "/Mechanic/Mecanico"},
            };
            

        }
        public IEnumerable<Personal> GetAll(){
            return TodoPersonal;
        }
    }
}