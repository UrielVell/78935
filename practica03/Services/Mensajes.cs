using System;
using System.ServiceModel;

namespace WSDL.mensajes
{
    [ServiceContract]
    public interface Mensajes{
        [OperationContract]
        string Agregar (string nombre);
        [OperationContract]
        string Buscar (int id);
    }
}