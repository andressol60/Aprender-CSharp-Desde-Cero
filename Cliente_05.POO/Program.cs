using _06.POO_ClasesYObjetos;

namespace Cliente_05.POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //referencio con el otro proyecto
            //Clieck en el proyecto con program luego en agregar referencia

            //Creo una instancia de persona
            //Es decir creo un molde del objeto persona y lleno sus caracteristicas con información
            //Deacuerdo al tipo de variable
            Persona persona = new Persona();
            persona.Nombre = "Juan";
            persona.Edad = 25;

            //llamo al metodo de la clase persona 
            persona.Saludar();
            Console.WriteLine("-----------------------------------------");
            Persona persona1 = new Persona();
            persona1.Nombre = "Maria";
            persona1.Edad = 24;
            persona1.Saludar();
            Console.WriteLine($"Nombre persona 1: {persona.Nombre}");

            Console.WriteLine("-----------------------------------------");
            Operaciones_matematicas ope = new Operaciones_matematicas(8, 5);
            Console.WriteLine($"Numero 1: {ope.Numero1}");
            Console.WriteLine($"Numero 2: {ope.Numero2}");
            Console.WriteLine($"Suma: {ope.suma()}");
            Console.WriteLine($"Resta: {ope.resta()}");
            Console.WriteLine($"Multiplicación: {ope.multiplicacion()}");
            Console.WriteLine($"División: {ope.division()}");

            Console.Read();
        }
    }
}
