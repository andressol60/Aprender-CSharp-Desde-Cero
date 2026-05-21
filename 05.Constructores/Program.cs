namespace _05.Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un costructor es un metodo dentro de las clases
            //que se ejecuta cuando instanciamos un objeto y ayuda a que 
            //se inicialicen los atributos del objeto.
            //tiene el mismo de la clase y es void es decir no retorna ningun valor
            //Se puede crear un constructor segun los atributos que vayas a usar
            //o se crea automaticamente un constructor vacio.
            Console.WriteLine("Hello, World!");
            Console.WriteLine("-----------------------------------------");
            Persona persona1 = new Persona();
            persona1.Nombre = "Patricio";
            Console.WriteLine($"El nombre de la persona 1 es: {persona1.Nombre}");

            Console.WriteLine("---------------------------------------------");

            Persona persona2 = new Persona("Juan", "Castro", 26);  //Instancia del objeto con datos en el constructor
            Console.WriteLine($"El nombre de la persona 2 es: {persona2.Nombre}");

            Console.Read();

        }
    }
}
