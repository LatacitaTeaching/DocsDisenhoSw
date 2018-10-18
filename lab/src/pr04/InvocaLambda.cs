using System;
using System.Collections.Generic;
using System.Text;

namespace Pr04_Strategy_Examples
{
    class InvocaLambda
    {
        static void Main(string[] args)
        {
            OrdenaLambda<int> ordenaEnteros = new OrdenaLambda<int>();

            List<int> listaEnteros = new List<int>();

            // Inicializamos la lista en orden decreciente
            for (int i=15;i>0; i--)
            {
                listaEnteros.Add(i);
            } // for

            Console.Out.WriteLine("Lista Inicial  = " + list2String(listaEnteros));

            // Primera Opción: Cambiado la propiedad que representa una función

            // Asignamos a la propiedad mayor de la clase OrdenaLamabda una función anónima 
            // lambda que acepta dos enteros (deducido por inferencia de tipos) que devuelve 
            // verdadero si el primero es mayor que el segundo 
            // ordenaEnteros.Mayor = (x, y) => x > y;
            // ordenaEnteros.ordenarBurbuja(listaEnteros);

            // Segunda opción: Pasando la función como parámetro
            ordenaEnteros.ordenarBurbuja(listaEnteros, (x, y) => x > y);

            Console.Out.WriteLine("Lista Ordenada = " + list2String(listaEnteros));

            Console.Out.WriteLine("Pulse INTRO para continuar.");
            Console.In.ReadLine();
        } // Main

        // Metodo auxiliar para convertir el contenido de una lista a cadena de caracteres
        private static String list2String<T>(List<T> listaElementos)
        {
            StringBuilder result = new StringBuilder("[");

            if (listaElementos.Count > 0) {

                for (int i = 0; i < listaElementos.Count - 1; i++)
                {
                    result.Append(listaElementos[i] + ", ");
                } // for

                result.Append(listaElementos[listaElementos.Count - 1]);   
            } // if
            
            result.Append("]");

            return result.ToString();
        } // serializaLista

    } // class Program
} // namespace
