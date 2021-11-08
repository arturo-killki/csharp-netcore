using System;
using CoreEscuela.Entidades;

// Probando actualización de la RAMA 3

// Y con esto actualización desde GitHUB

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

            /*
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
            */
            /*
            // La forma anterior se puede optimizar del siguiente modo
            Curso[] arregloCursos = {
                new Curso() {Nombre="101"},
                new Curso() {Nombre="201"},
                new Curso() {Nombre="301"}
            };
            // Y para asignar los cursos a Escuela, que ya tiene el atributo de Cursos[]
            escuela.Cursos = arregloCursos;
            */

            // Última optimización de esta parte del código
            escuela.Cursos = new Curso[] {
                new Curso() {Nombre="101"},
                new Curso() {Nombre="201"},
                new Curso() {Nombre="301"}
            };

            /*
            Console.WriteLine(escuela);
            Console.WriteLine("========================");
            // Cambiar la impresión de los cursos línea por línea a por arreglo
            // Se utiliza un método para esta operación
            / *
            Console.WriteLine(curso1.UniqueId + " - " + curso1.Nombre);
            Console.WriteLine(curso2.UniqueId + " - " + curso2.Nombre);
            Console.WriteLine(curso3.UniqueId + " - " + curso3.Nombre);
            * /
            ImprimirCursosWhile(arregloCursos);
            ImprimirCursosDoWhile(arregloCursos);
            ImprimirCursosFor(arregloCursos);
            ImprimirCursosForeach(arregloCursos);
            */

            // Vamos a enviar a una función la impresión de los cursos
            ImprimirCursosEscuela(escuela);

        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Cursos de la ESCUELA de KILLKI");
            Console.WriteLine("==============================");

            // Verificando que los obejtos no estén como nulos
            if (escuela != null && escuela.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    Console.WriteLine($"Nombre: {curso.Nombre} - ID: {curso.UniqueId}");
                }
            }
        }
        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            // Para barrer el arreglo, se usará while + contador
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console.WriteLine(arregloCursos[contador].UniqueId + " - " +
                    arregloCursos[contador].Nombre);
                contador++;
            }
            Console.WriteLine("===============================");
        }
        // Otra forma de recorrer el arreglo: DO... WHILE
        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            // Para barrer el arreglo, se usará while + contador
            int contador = 0;
            do
            {
                Console.WriteLine(arregloCursos[contador].UniqueId + " - " +
                    arregloCursos[contador].Nombre);
                contador++;
            } while (contador < arregloCursos.Length);
            Console.WriteLine("===============================");
        }
        // Otra forma de recorrer el arreglo: FOR
        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            // Para barrer el arreglo, se usará while + contador
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                Console.WriteLine(arregloCursos[i].UniqueId + " - " +
                    arregloCursos[i].Nombre);
            }
            Console.WriteLine("===============================");
        }
        // La forma más eficiente de recorrer el arreglo: FOREACH
        private static void ImprimirCursosForeach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                Console.WriteLine(curso.UniqueId + " - " + curso.Nombre);
            }
            Console.WriteLine("===============================");
        }
    }
}

