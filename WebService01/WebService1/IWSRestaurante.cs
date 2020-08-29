using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSRestaurante
    {

        [OperationContract]
        Orden ObtenerEstado(int NoOrden);

        [OperationContract]
        string CrearOrden();

        // TODO: agregue aquí sus operaciones de servicio
    }

    //Clase para obtener los datos de la orden en el restaurante 
    [DataContract]
    public class Orden : BaseResponse
    {

        [DataMember]
        public string estado { get; set; } 
    }

    [DataContract]
    public class BaseResponse
    {
        [DataMember]
        public string Error { get; set; }
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
