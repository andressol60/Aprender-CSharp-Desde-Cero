namespace _06.POO_ClasesYObjetos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {Nombre} y tengo {Edad}");
        }
    }
}
