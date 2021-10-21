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

            var curso1 = new Curso() { Nombre = "101"};
            var curso2 = new Curso() { Nombre = "201"};
            var curso3 = new Curso() { Nombre = "301"};

            Console.WriteLine(escuela);
            Console.WriteLine("========================");
            Console.WriteLine(curso1.UniqueId + " - " + curso1.Nombre);
            Console.WriteLine(curso2.UniqueId + " - " + curso2.Nombre);
            Console.WriteLine(curso3.UniqueId + " - " + curso3.Nombre);
        }
    }
}
