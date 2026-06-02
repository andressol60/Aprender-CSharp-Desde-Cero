namespace _07.POO_Herencia
{
    public class Perro : Animal    //perro hereda de Animal sus atributos
    {

        public string Raza { get; set; }

        public Perro(string nombre, int edad, string raza)
            : base(nombre, edad)  // llama al constructor de Animal
        {
            Raza = raza;
        }

        public void Ladrar()
        {
            Console.WriteLine($"{Nombre} está ladrando");
        }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} dice: Guau!");
        }

    }
}
