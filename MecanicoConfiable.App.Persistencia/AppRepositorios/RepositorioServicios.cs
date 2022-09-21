using System.Collections.Generic;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    
    public class RepositorioServicios : IRepositorioServicios
    {
        List<Servicio> TServiciosAux;
        List<Servicio> TServiciosMec;


        public RepositorioServicios(){

            
            TServiciosAux =  new List<Servicio>{ new Servicio { 
                    Titulo = "Vehiculos",
                    Descripcion = "Vehiculos actuales de la empresa",
                    ImagenUrl = "/imagenes/Vehiculo.png",
                    Link = "/Services/car/Vehiculo",
                    LinkList = "/Services/car/ListVehiculo"},
                    new Servicio { 
                    Titulo = "Seguros",
                    Descripcion = "Seguros asignados a los vehiculos",
                    ImagenUrl = "/imagenes/poliza.png",
                    Link = "/Services/car/ListVehiculo",
                    LinkList = "/Services/SegurosVehiculos/ListSegurosActuales"},
            };
              TServiciosMec =  new List<Servicio>{ 
                    new Servicio { 
                    Titulo = "Repuestos",
                    Descripcion = "Todos los repuestos en existencia",
                    ImagenUrl = "/imagenes/Repuestos.png",
                    Link = "/Services/Parts/Repuestos"},
                    new Servicio { 
                    Titulo = "Revisión de niveles",
                    Descripcion = "Revisiónes de los vehiculos",
                    ImagenUrl = "/imagenes/Rniveles.png",
                    Link = "/Services/Levels/Niveles",
                    LinkList = "/Services/Levels/ListNiveles"},
                    new Servicio { 
                    Titulo = "Cambio de repuestos",
                    Descripcion = "Registro de cambio de repuestos",
                    ImagenUrl = "/imagenes/CambioRepuestos.png",
                    Link = "/Mechanic/Mecanico"},
                    new Servicio { 
                    Titulo = "Vehiculos Asignados",
                    Descripcion = "Registro de vehiculos asignados para cada mecánico",
                    ImagenUrl = "/imagenes/Libreta.png",
                    Link = "/Services/car/Vehiculo",
                    LinkList = "/Services/VehiculosAsignados/ListMechanics"},
            };
            
        }
        public IEnumerable<Servicio> GetAllForAux(){
            return TServiciosAux;
        }
        public IEnumerable<Servicio> GetAllForMech(){
            return TServiciosMec;
        }
        
    }
}