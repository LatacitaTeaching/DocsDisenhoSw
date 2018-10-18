using System;
using System.Collections.Generic;

namespace Pr04_Strategy_Examples
{

    // Declaracion de un delegado o tipo de datos que representa una funcion
    delegate bool EsMayor<T>(T izq, T dch);

    public class OrdenaLambda<T>
    {

        // Declaracion de un atributo cuyo tipo es una funcion utilizando un 
        // tipo delegado propio
        private EsMayor<T> mayorDelegado;

        // Declaracion de un atributo cuyo tipo es una funcion utilizando un 
        // tipo delegado predefinido
        // Inv: mayor != null
        private Func<T, T, bool> mayor;

        // Declaracion de una propiedad cuyo tipo es una funcion
        // pre: value != null
        public Func<T, T, bool> Mayor {
            set { this.mayor = value; }
        } // Mayor

        // Metodo que ordena la lista de elementos utilizando para comparar elementos 
        // la funcion de mayor contenida en el correspondiente atributo de la clase
        // pre: listaElementos != null and this.mayor != null 
        //      and listaElementos.forAll(e : e != null)
        public void ordenarBurbuja(List<T> listaElementos)
        {
            ordenarBurbuja(listaElementos, mayor);
        } // ordenarBurbuja

        // Metodo que ordena la lista de elementos utilizando para comparar elementos 
        // la funcion de mayor especificada como parámetro
        // pre: listaElementos != null and mayor != null 
        //      and listaElementos.forAll(e : e != null)
        public void ordenarBurbuja(List<T> listaElementos, Func<T,T,bool> mayor)
        {
            for(int i = 0;i<listaElementos.Count-1;i++) {
                for (int j = 0;j<listaElementos.Count-i-1;j++)
                {
                    if (mayor(listaElementos[j], listaElementos[j+1])) {
                        T temp = listaElementos[j];
                        listaElementos[j] = listaElementos[j + 1];
                        listaElementos[j+1] = temp;
                    } // if
                } // for j
            } // for i 
        } // ordenarBurbujaParametro
        
    } // class 
} // namespace
