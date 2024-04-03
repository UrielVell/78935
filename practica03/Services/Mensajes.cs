using System;
using System.ServiceModel;

namespace WSDL.mensajes
{
    [ServiceContract]
    public interface Mensajes{
        [OperationContract]
        int Suma (int num1, int num2);
        [OperationContract]
        int Resta (int num1, int num2);
        [OperationContract]
        int Multiplicacion (int num1, int num2);
        [OperationContract]
        double Division (int num1, int num2);
    }
}