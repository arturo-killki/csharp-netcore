using System;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        // Al set se le convierte en private para que solo pueda ser asignado dentro
        //    de esta clase.
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }

        public Curso()
        {
            UniqueId=Guid.NewGuid().ToString();
        }
    }
}