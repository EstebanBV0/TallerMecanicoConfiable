using System.Collections.Generic;
using MecanicoConfiable.App.Dominio;


namespace MecanicoConfiable.App.Persistencia

{

    public class RepositorioPersonal : IRepositorioPersonal
    {
        List<Personal> TodoPersonal;
        public RepositorioPersonal()
        {
            TodoPersonal = new List<Personal>{ new Personal {
                    Titulo = "Mecanicos",
                    Descripcion = "Personal encargado del mantenimiento y la reparacion de los automoviles",
                    ImagenUrl = "/imagenes/Mecanico.png",
                    Link = "/Administracion/Mechanic/Mecanico",
                    LinkList = "/Administracion/Mechanic/ListMecanicos"},
                    new Personal {
                    Titulo = "Auxiliares",
                    Descripcion = "Personal encargado de la administracion",
                    ImagenUrl = "/imagenes/auxiliar.png",
                     Link = "/Mechanic/Mecanico",
                    LinkList = "/Mechanic/Mecanico"},
                    new Personal {
                    Titulo = "Dueños",
                    Descripcion = "Dueños de veniculos",
                    ImagenUrl = "/imagenes/Dueño.png",
                    Link = "/Mechanic/Mecanico",
                    LinkList = "/Mechanic/Mecanico"},
                    new Personal {
                    Titulo = "Conductores",
                    Descripcion = "Personal encargado del manejo de los vehiculos",
                    ImagenUrl = "/imagenes/Conductores.png",
                    Link = "/Mechanic/Mecanico",
                    LinkList = "/Mechanic/Mecanico"},
            };
        }
        public IEnumerable<Personal> GetAll()
        {
            return TodoPersonal;
        }
    }
}