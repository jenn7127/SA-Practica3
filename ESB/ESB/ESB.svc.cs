using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ESB
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ESB : IESB
    {



        public string CrearOrden()
        {

            var client = new WebServRestaurante.WSRestaurante();
            return client.CrearOrden();
            
        }

        public Orden ObtenerEstado(int NoOrden)
        {

            
            var client = new WebServRestaurante.WSRestaurante();
            string estado1 = client.ObtenerEstado(NoOrden, true).estado;
            string error = client.ObtenerEstado(NoOrden, true).Error;
            if (estado1 == null)
            {
                return new Orden() { Error = error };
            }
            else
            {
                return new Orden() { estado = estado1 };
            }


        }


    }
}
