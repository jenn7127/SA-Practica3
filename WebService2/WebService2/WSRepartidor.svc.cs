using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService2
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSRepartidor : IWSRepartidor
    {
        public string EnviarOrden(int NoOrden)
        {
            return ("orden: " + NoOrden + "enviada al repartidor");
        }

        public Orden ObtenerEstadoRep(int NoOrden)
        {

             if (NoOrden == 2)
            {
                return new Orden() { estado = "Entregado" };
            }
            else if (NoOrden == 4)
            {
                return new Orden() { estado = "En Ruta" };
            }
            else
            {
                return new Orden() { Error = "orden no encontrada" };
            }
        }
    }
}
