using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService3
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string CambiarEstado(int NoOrden)
        {
            return "Estado de Orden"+ NoOrden+" Cambiado";
        }

        public Orden ObtenerEstadoCli(int NoOrden)
        {

            if (NoOrden == 2)
            {
                return new Orden() { estado = "Entregado" };
            }
            else if (NoOrden == 4)
            {
                return new Orden() { estado = "En Ruta" };
            }
            if (NoOrden == 1)
            {
                return new Orden() { estado = "En Restaurante" };
            }
            else if (NoOrden == 3)
            {
                return new Orden() { estado = "En Restaurante" };
            }
            else
            {
                return new Orden() { Error = "orden no encontrada" };
            }
        }
    }
}
