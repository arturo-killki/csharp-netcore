using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    class Escuela
    {
        // se define un atributo de Escuela: nombre
        string nombre;

        // este atributo lo encapsulamos en una propiedad: Nombre
        // por convención, el atributo en minúscula, la propiedad en mayúscula.
        public string Nombre
        {
            // si piden el atributo, se devuelve
            get { return nombre; }
            // si asignan un atributo, se guarda lo que hay en 'value'
            // .ToUpper() para pasar a mayúsculas
            set { nombre = value.ToUpper(); }
        }

        // Se puede crear una propiedad de manera más directa con este código
        public int AñoCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        // Atributo tipo de escuela trabaja con una enumeración
        // Tener en cuenta que TipoEscuela será del tipo TiposEscuela
        public TiposEscuela TipoEscuela { get; set; }
        // Se cambia del tipo array al tipo Colección
        public List<Curso> Cursos { get; set; }
        /*
        public Curso[] Cursos { get; set; }
        */

        // Acá se arma el constructor que inicializa los parámetros
        // El parámetro puede tener el mismo nombre de un atributo o no. Si tienen el
        //    el mismo nombre, para haner referencia al atributo de la clase usar antes "this."
        // Cuando se cree un objeto o variable en el programa principal, se deberán incluir
        //    los parámeteros acá solicitados
        public Escuela(string nombre, int año)
        {
            this.nombre = nombre;
            AñoCreacion = año;
        }

        /*
        // Otra forma más corta de crear este constructor es la igualación por tuplas.
        public Escuela(string nombre, int año) => (Nombre, AñoCreacion) = (nombre, año);
        */

        // Otro constructor con el mismo nombre: Escuela, pero con diferentes parámetros
        public Escuela(string nombre, int año, TiposEscuela tipo, string pais = "",
            string ciudad = "")
        {
            // Se puede usar asignación por tuplas
            (Nombre, AñoCreacion) = (nombre, año);
            TipoEscuela = tipo;
            Pais = pais;
            Ciudad = ciudad;
        }


        // Acá se sobreescribe el método ToString() para esta clase con el fin de que al 
        //    imprimir el objeto escuela muestre los datos que nos interesa
        // Para indicar que se está sobreescribiendo usar la palabra "override"
        // Para hacer salto de línea se usa: \n
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\" - Tipo: {TipoEscuela} \nPaís: {Pais} - Ciudad: {Ciudad}";
        }
    }
}