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



            Console.Read();
        }
    }
}
