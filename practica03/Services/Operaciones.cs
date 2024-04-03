using System;
using WSDL.mensajes;

namespace WSDL.operaciones
{
    public class Operaciones : Mensajes{
        // List<string> lista = new List<string>();
        // public string Agregar(string nombre){
        //     lista.Add(nombre);
        //     return "Hola "+ nombre + ", has sido agregado.";
        // }

        // public string Buscar(int id){
        //     if (id > lista.Count-1)
        //     {
        //         return "No hay registro";
        //     }
        //     string persona = lista[id];
        //     return "Encontrad@: " + persona;
        // }

        public int Suma (int num1, int num2){
            return num1+num2;
        }

        public int Resta (int num1, int num2){
            return num1-num2;
        }

        public int Multiplicacion (int num1, int num2){
            return num1*num2;
        }

        public double Division (int num1, int num2){
            return num1/num2;
        }
    }
}