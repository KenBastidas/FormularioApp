using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC
{
    //un espacio de nombres es un contenedor logico de clases
    //permite agrupar varis clases dentro de ese espacio 
    //ejemplo: TIC.Utilidades
    class utilidades
    {
        //tabla de multiplicar 
        /*modificadores de acceso: public, private, protected
         * public: toda clase accede al metodo o funcion
         * private: solo la propia clase accede al metodo o funcion
         * protected: solo las clases que heredan de la clase base puede acceder al metodo o funcion
         */
        /// <summary>
        /// la funcion calcula una tabla de multiplicar
        /// </summary>
        /// <param name="tabla">la tabla a calcular</param>
        /// <returns>una cadena con la tabla calcular</returns>
        public static String CalculaTabla(int tabla)
        {
            //las funciones estaticas se pueden ustilizar sin necesidad de crear una instancia de la clase 
            String aux = " ";
            for (int i = 1; i <= 12; i++)
            {
                aux = aux + tabla.ToString() + " x " + i.ToString() + " = " + (tabla * i);
                aux = aux + Environment.NewLine; //enviroment.NewLine salto de linea
            }
            return aux;
        }
        /// <summary>
        /// Calcular el factorial de un entero
        /// </summary>
        /// <param name="num">Representa el entero al que se le calcular el factorial</param>
        /// <returns>Devuelve el valor</returns>
        //funcion factorial
        public static long factorial(int num)
        {
            long fac = 1;
            if (num == 0)
                return 1;  //retorna y abandona la funcion

            for (int i = 1; i <= num; i++)
                fac *= i;

            return fac;
        }


        public static long Serie(int Limite)
        {
            long a = 0;
            long suma = 0;
            for (int i = 1; i <= Limite; i++)
            {
                a = factorial(i);
                suma += a;
            }
            return suma;
        }

    }
}
