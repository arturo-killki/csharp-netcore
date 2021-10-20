using System;
using CoreEscuela.Entidades;

namespace csharp_netcore
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Se crea una variable a partir de la clase Escuela. Ojo con los parámetros
            var escuela = new Escuela("Killki University", 2019);
            // Los valores que no están como parámetros se asignan directamente
            escuela.Pais = "Perú";
            escuela.Ciudad = "Lima";
            // Tipo de escuela es del tipo TiposEscuela, por lo tanto solo se le pueden
            //    asignar valores de la enumeración correspondiente.
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            */

            // Hacer lo mismo que el de arriba pero con otro constructor
            var escuela = new Escuela("Killki University", 2019, TiposEscuela.Secundaria,
                ciudad:"Lima");
            escuela.Pais = "Perú";

            /*
            // Imprimir datos
            Console.WriteLine(escuela.Nombre);
            */
            // Imprimir datos con método ToString() sobreescrito
            // Esta línea (imprimir objeto) de manera predeterminada imprime el nombre 
            //    completo del objeto. Para que imprima otra cosa, sobreescribie el método en
            //    la clase Escuela
            Console.WriteLine(escuela);
        }
    }
}
