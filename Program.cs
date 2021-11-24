using System;
using System.Collections.Generic;
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

            // Pasar la creación de curso de Array a Colecciones
            // Se usa colección tipo lista
            // También hay que modidifcar en la entidad curso para que se indique que se 
            //     trabajará con una colección y no con un array
            // Respecto al array anterior, acá le agregamos hormada
            escuela.Cursos = new List<Curso>(){
                new Curso() {Nombre="101", Jornada=TiposJornada.Mañana},
                new Curso() {Nombre="201", Jornada=TiposJornada.Mañana},
                new Curso() {Nombre="301", Jornada=TiposJornada.Mañana}
            };
            /*
            escuela.Cursos = new Curso[] {
                new Curso() {Nombre="101"},
                new Curso() {Nombre="201"},
                new Curso() {Nombre="301"}
            };
            */

            // A las colecciones, a diferencia de los array se les puede agregar elementos
            escuela.Cursos.Add(new Curso { Nombre = "102", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso { Nombre = "202", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso { Nombre = "302", Jornada = TiposJornada.Tarde });
            // Incluso se le puede agregar una colección completa
            var otraColeccion = new List<Curso>(){
                new Curso {Nombre="401", Jornada=TiposJornada.Noche},
                new Curso {Nombre="501", Jornada=TiposJornada.Noche},
                new Curso {Nombre="601", Jornada=TiposJornada.Noche}
            };
            escuela.Cursos.AddRange(otraColeccion);

            // Para ejemplo de cómo remover un curso usando delegados
            // Se removerá el curso 301
            /*
            Predicate<Curso> miAlgoritmo = Predicado;
            escuela.Cursos.RemoveAll(miAlgoritmo);
            */
            // Se puede escribir directo como un delegado
            /*
            escuela.Cursos.RemoveAll(delegate (Curso cur)
                {
                    return cur.Nombre == "302";
                });
            */
            // También se puede escribir como expresión Lambda
            escuela.Cursos.RemoveAll((cur) => cur.Nombre == "401");


            // Vamos a enviar a una función la impresión de los cursos
            ImprimirCursosEscuela(escuela);

        }

        private static bool Predicado(Curso curobj)
        {
            return curobj.Nombre == "301";
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

