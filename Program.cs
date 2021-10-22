using System;
using CoreEscuela.Entidades;

namespace csharp_netcore
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Killki University", 2019, TiposEscuela.Secundaria,
                ciudad: "Lima");
            escuela.Pais = "Perú";

            // Pasar la creación de cursos a arreglos
            /*
            var curso1 = new Curso() { Nombre = "101"};
            var curso2 = new Curso() { Nombre = "201"};
            var curso3 = new Curso() { Nombre = "301"};
            */
            // Se define el arreglo
            var arregloCursos = new Curso[3];
            // Elemento 1 del arreglo
            arregloCursos[0] = new Curso
            {
                Nombre = "101"
            };
            // Elemento 2 del arreglo, creado de otro modo
            var curso2 = new Curso
            {
                Nombre = "201"
            };
            arregloCursos[1] = curso2;
            // Eleemnto 3 del arreglo
            arregloCursos[2] = new Curso
            {
                Nombre = "301"
            };

            Console.WriteLine(escuela);
            Console.WriteLine("========================");
            // Cambiar la impresión de los cursos línea por línea a por arreglo
            // Se utiliza un método para esta operación
            /*
            Console.WriteLine(curso1.UniqueId + " - " + curso1.Nombre);
            Console.WriteLine(curso2.UniqueId + " - " + curso2.Nombre);
            Console.WriteLine(curso3.UniqueId + " - " + curso3.Nombre);
            */
            ImprimirCursos(arregloCursos);
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            // Para barrer el arreglo, se usará while + contador
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console.WriteLine(arregloCursos[contador].UniqueId + " - " +
                    arregloCursos[contador].Nombre);
                contador++;
            }
        }
    }
}
