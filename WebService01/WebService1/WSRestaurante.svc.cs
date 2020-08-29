using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSRestaurante : IWSRestaurante
    {
        List<string> estados = new List<string>();


        public string CrearOrden()
        {

            return "orden creada exitosamente";
        }

        public Orden ObtenerEstado(int NoOrden)
        {
            
           if (NoOrden == 1)
            {
                return new Orden() { estado = "En Proceso" };
            }
           else if (NoOrden == 2)
            {
                return new Orden() { estado = "Enviado" };
            }
           else if (NoOrden == 3)
            {
                return new Orden() { estado = "En Proceso" };
            }
            else if (NoOrden == 4)
            {
                return new Orden() { estado = "Enviado" };
            }
            else
            {
                return new Orden() { Error = "orden no encontrada" };
            }
        }


    }
}
